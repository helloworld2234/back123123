using AxKHOpenAPILib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Tls;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Media.Animation;
using MaterialDesignColors.Recommended;

namespace BackTesting {
    partial class BACK_TEST_FORM {
        const string 기본정보_스크린 = "1000";
        const string 장세판단_스크린 = "2000";

        private bool 로그인플레그 = false;

        class PriceInfoEntityObject {
            public string 일자 { get; set; }
            public double 시가 { get; set; }
            public double 고가 { get; set; }
            public double 저가 { get; set; }
            public double 현재가 { get; set; }
            //public double 이동평균선 { get; set; }
        }

        List<PriceInfoEntityObject> kospi_InfoList = new List<PriceInfoEntityObject>();
        List<PriceInfoEntityObject> kosdaq_InfoList = new List<PriceInfoEntityObject>();
        public void kiwoom() {

            chart_init();
            키움API.OnEventConnect += OnEventConnect; //로그인시 이벤트를 받는 곳 
            키움API.OnReceiveTrData += OnReceiveTrData; // TR데이터를 받는 곳
            
        }
        // 로그인 
  

        private void Kiwoom_Login_btn_Click(object sender, EventArgs e) {
            키움API.CommConnect();
        }
      
        // 기본정보받기
        
        private void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e) {
            
            if (e.nErrCode == 0) {  // 로그인에 성공하는 경우 기본 정보를 가져온다.

                로그인플레그 = true;

                LogTextset("키움", "로그인 완료");
                string 계좌목록 = 키움API.GetLoginInfo("ACCLIST").Trim();
                string[] 사용자계좌 = 계좌목록.Split(';');

                for (int i = 0; i < 사용자계좌.Length; i ++) {
                    Account_list_combo.Items.Add(사용자계좌[i]);
                }

                string 사용자ID = 키움API.GetLoginInfo("USER_ID");
                Get_user_name.Text = 사용자ID;

                string 사용자이름 = 키움API.GetLoginInfo("USER_NAME");
                Get_user_id.Text = 사용자이름 ;

                string 접속서버 = 키움API.GetLoginInfo("GetServerGubun");
                if (접속서버=="1") {
                    Get_user_server.Text = "모의서버";
                }
                else {
                    Get_user_server.Text = "실서버";
                }
                LogTextset("키움", "기본정보 완료");

            }
            else {
                LogTextset("키움", "로그인 실패 "+ e.nErrCode);
            }
        }

        /// <summary>
        /// TR 관련
        /// </summary>

        /* TR요청 */ 
        private void Deposit_btn_Click(object sender, EventArgs e) {

            string 계좌번호 = Account_list_combo.Text;
            if (계좌번호 == null) {
                LogTextset("키움", "계좌번호를 선택해주세요.");
                return;
            }
            키움API.SetInputValue("계좌번호", 계좌번호);
            if (Get_user_server.Text == "모의서버") {
                키움API.SetInputValue("비밀번호", "0000");
            }
            else {
                키움API.SetInputValue("비밀번호", "0000");//
            }
            키움API.SetInputValue("비밀번호", "00");
            키움API.SetInputValue("조회구분", "2");

            키움API.CommRqData("계좌잔고평가내역", "opw00018", 0, 기본정보_스크린); // TR요청

        }
        private void req_market_btn_Click(object sender, EventArgs e) {
            코스피_요청();
            코스닥_요청();
        }

        private void 코스피_요청() {

            키움API.SetInputValue("업종코드", "001"); // 001 : 코스피
            키움API.SetInputValue("기준일자",  DateTime.Now.ToString("yyyyMMdd"));
            키움API.CommRqData("코스피_요청", "opt20006", 0, 장세판단_스크린 );

        }
        private void 코스닥_요청() {
            키움API.SetInputValue("업종코드", "101"); // 101 : 코스닥
            키움API.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            키움API.CommRqData("코스닥_요청", "opt20006", 0, 장세판단_스크린);
        }

        /* TR데이터 받는곳 */
        private void OnReceiveTrData(object sender , AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e) {

            if ( e.sRQName == "계좌잔고평가내역") {
                // ㅁㅁㅁ.Parse는 00000000  <- 이러한 값을 제거해줌
                int 예수금 = int.Parse( 키움API.GetCommData( e.sTrCode, e.sRQName, 0, "추정예탁자산" ) );
                Get_Deposit.Text = String.Format("{0:#,##0}", 예수금); // 돈 쉼표(,) 표시
            }
            else if(e.sRQName == "코스피_요청") {
                코스피요청_처리( 키움API.GetRepeatCnt(e.sTrCode, e.sRecordName) , e );
            }
            else if(e.sRQName == "코스닥_요청") {
                //코스닥요청_처리(키움API.GetRepeatCnt(e.sTrCode, e.sRecordName), e);
            }
        }

        /*받은 TR 데이터 처리 */
        private void 코스피요청_처리(int repeat, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e) {

            kospi_InfoList.Clear();
            kospi_chart.Annotations.Clear();
            kospi_chart.Series[0].Points.Clear();

            double max = 0;
            double min = 0;

            bool flowing_flag = false;
            bool buy = false;
            double buy_price_max = 0;
            double buy_price = 0;
           

            //값을 List에 추가 
            for (int index = 0; index < repeat; index++) {
                
                kospi_InfoList.Add(new PriceInfoEntityObject()
                {
                    일자 = 키움API.GetCommData(e.sTrCode, e.sRQName, index, "일자").Trim(),
                    시가 = double.Parse(키움API.GetCommData(e.sTrCode, e.sRQName, index, "시가").Trim()) * 0.01,
                    고가 = double.Parse(키움API.GetCommData(e.sTrCode, e.sRQName, index, "저가").Trim()) * 0.01,
                    저가 = double.Parse(키움API.GetCommData(e.sTrCode, e.sRQName, index, "고가").Trim()) * 0.01,
                    현재가 = double.Parse(키움API.GetCommData(e.sTrCode, e.sRQName, index, "현재가").Trim()) * 0.01
                });
            }
            // List를 뒤집음
            kospi_InfoList.Reverse();

            for (int index = 0; index < kospi_InfoList.Count; index++) {
               

                if (index == 0) {   // max, min
                    max = kospi_InfoList[0].고가;
                    min = kospi_InfoList[0].저가;
                }
                if (max < kospi_InfoList[index].고가) {
                    max = kospi_InfoList[index].고가;
                }
                if (min > kospi_InfoList[index].저가) {
                    min = kospi_InfoList[index].저가;
                }
                //Console.WriteLine("{0} {1}", kospi_InfoList[index].일자, kospi_InfoList[index].현재가);
                kospi_chart.Series[0].Points.AddXY(kospi_InfoList[index].일자, kospi_InfoList[index].고가);
                kospi_chart.Series[0].Points[index].YValues[1] = kospi_InfoList[index].저가;
                kospi_chart.Series[0].Points[index].YValues[2] = kospi_InfoList[index].시가;
                kospi_chart.Series[0].Points[index].YValues[3] = kospi_InfoList[index].현재가;

                if (index > 20) {
                    if (buy) {
                        if( kospi_InfoList[index].현재가 < buy_price*0.97 ) {
                            buy = false; // 손절
                            //Console.WriteLine("진입");
                           
                        }
                        if( kospi_InfoList[index].현재가 > buy_price * 1.03) {
                            flowing_flag = true;
                            if (buy_price  > buy_price_max) { buy_price_max = buy_price; }

                            if(kospi_InfoList[index].현재가 < buy_price_max * 0.98) {
                                buy = false;    //익절 
                                flowing_flag = false;
                            }

                        }
                    }
                    else {

                        if (kospi_InfoList[index].현재가 > kospi_InfoList[index - 20].고가) {
                            buy_price = kospi_InfoList[index].현재가;
                            buy = true;
                        }

                    }
                    if (flowing_flag ) {
                        kospi_chart.Annotations.Add(ArrowAdd(index, kospi_chart, Color.Aqua));
                    }


                }
               

            }

            kospi_chart.ChartAreas["ChartArea1"].AxisY.Maximum = max;
            kospi_chart.ChartAreas["ChartArea1"].AxisY.Minimum = min;


        }
        


        private void chart_init() {

            kospi_chart.Series[0]["PriceUpColor"] = "Red";
            kospi_chart.Series[0]["PriceDownColor"] = "Blue";
            //kosdaq_chart.Series[0]["PriceUpColor"] = "Red";
            //kosdaq_chart.Series[0]["PriceDownColor"] = "Blue";

            kospi_chart.AxisViewChanged += chart_AxisViewChanged;
            //kosdaq_chart.AxisViewChanged += chart_AxisViewChanged;

        }
    }

   
}
