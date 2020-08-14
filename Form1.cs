
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BackTesting {
    public partial class BACK_TEST_FORM : Form {

        LinkedList<string> tempLines = new LinkedList<string>(); // 로그용
        StringBuilder log_str = new StringBuilder();

        public BACK_TEST_FORM() {
            /* 메인소스는 여기 */
            InitializeComponent();
            kiwoom();


        }
        
        private ArrowAnnotation ArrowAdd(int index ,Chart chart_, Color color_) { // 그래프 화살표 주석  
            /*       for( index = 0; index< 값; index++ ){
             *              chart.Annotations.Add( ArrowAdd(index, chart)  );  <- 사용법
             *       
             *      }
             */
            ArrowAnnotation myAnno = new ArrowAnnotation();
            myAnno.AllowMoving = false;
            myAnno.BackColor = color_;
            myAnno.Height = -5;
            myAnno.Width = 0;
            myAnno.LineWidth = 1;
            myAnno.ArrowSize = 1;
            myAnno.AnchorOffsetY = -5;
            myAnno.AnchorDataPoint = chart_.Series[0].Points[index];
            //kospi_chart.Annotations.Add(myAnno);

            return myAnno;
        }
        public void LogTextset(string tab, string log) {

            const int nLimitLines = 35; //제한 라인 수
            try {
                string AppendMessage = DateTime.Now.ToString( tab + " : " + log +"\r\n");
                Log_Text.AppendText(AppendMessage);

                if (Log_Text.Lines.Length > nLimitLines) {
                    LinkedList<string> tempLines = new LinkedList<string>(Log_Text.Lines);

                    while ((tempLines.Count - nLimitLines) > 0) {
                        tempLines.RemoveFirst();
                    }

                    Log_Text.Lines = tempLines.ToArray();
                }
                Log_Text.Select(Log_Text.Text.Length, 0);
                Log_Text.ScrollToCaret();
            }
            finally { }
        }

        /* 유사도 탭 */
        private void corr_calc_btn_Click(object sender, EventArgs e) {
           
            if (StartDayFlag && EndDayFlag && defaultcodeFlag) {
                corr_calc_btn.Enabled = false;

                sim_result_grid.Rows.Clear();
                corr_calc_call();
            }
        }

        private void StartDayPicker_ValueChanged(object sender, EventArgs e) {
            StartDay = StartDayPicker.Value;
            StartDayFlag = true;

            LogTextset("유사도", "시작 날짜 선택 완료");
 
        }
        private void EndDayPicker_ValueChanged(object sender, EventArgs e) {
            EndDay = EndDayPicker.Value;
            EndDayFlag = true;

            LogTextset("유사도", "마지막 날짜 선택 완료");
        }
        private void sim_search_btn_Click(object sender, EventArgs e) {

            sim_item_grid.Rows.Clear();
            item_grid_fill_call();

        }

        private void sim_item_grid_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {

                int rowIndex = sim_item_grid.CurrentRow.Index;
                if (Run_sim_Flag == false) {

                    default_code = sim_item_grid.Rows[rowIndex].Cells[0].Value.ToString();
                    LogTextset("유사도", "종목 선택 완료");
                    if (EndDayFlag && StartDayFlag) {
                        Stock_var stock = new Stock_var();
                        marketdb DB = new marketdb();

                        stock.daily_data = DB.get_daily_price(default_code, StartDay, EndDay);

                        double min = Convert.ToDouble(stock.daily_data.AsEnumerable().Min(row => row["close"]));
                        double max = Convert.ToDouble(stock.daily_data.AsEnumerable().Max(row => row["close"]));
                        min = min * 0.95;
                        max = max * 1.05;
                        default_graph.Series[0].Name = sim_item_grid.Rows[rowIndex].Cells[1].Value.ToString();
                        default_graph.DataSource = stock.daily_data;
                        default_graph.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 1;
                        default_graph.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 1;
                        if (max != min) {
                            default_graph.ChartAreas["ChartArea1"].AxisY.Maximum = max;
                            default_graph.ChartAreas["ChartArea1"].AxisY.Minimum = min;
                        }
                        default_graph.Series[0].XValueType = ChartValueType.Date;
                        default_graph.Series[0].XValueMember = "date";
                        default_graph.Series[0].IsXValueIndexed = true;
                        default_graph.Series[0].YValueMembers = "high,low,open,close";
                        default_graph.Series[0].CustomProperties = "PriceDownColor=Blue,PriceUpColor=Red";
                        default_graph.Series[0]["OpenCloseStyle"] = "Triangle";
                        default_graph.Series[0]["ShowOpenClose"] = "Both";
                        default_graph.DataBind();


                    }
                        defaultcodeFlag = true;
                    }
                    
                }
                catch (Exception ex) {
                    Console.WriteLine("Item_grid_CellClick error");
                    Console.WriteLine(ex);
                }

        }

        private void sim_result_grid_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                Stock_var stock = new Stock_var();
                marketdb DB = new marketdb();
                stock.company_info = DB.get_company_info();

                int rowIndex = sim_result_grid.CurrentRow.Index;
                string target_code = sim_result_grid.Rows[rowIndex].Cells[0].Value.ToString();
                

                if (EndDayFlag && StartDayFlag) {

                    stock.daily_data = DB.get_daily_price( stock.company_info.FirstOrDefault(x => x.Value == target_code).Key , StartDay, EndDay);

                    double min = Convert.ToDouble(stock.daily_data.AsEnumerable().Min(row => row["close"]));
                    double max = Convert.ToDouble(stock.daily_data.AsEnumerable().Max(row => row["close"]));
                    min = min * 0.8;
                    max = max * 1.2;
                    target_graph.Series[0].Name = sim_result_grid.Rows[rowIndex].Cells[0].Value.ToString();
                    target_graph.DataSource = stock.daily_data;
                    target_graph.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 1;
                    target_graph.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 1;
                    if (max != min) {
                        target_graph.ChartAreas["ChartArea1"].AxisY.Maximum = max;
                        target_graph.ChartAreas["ChartArea1"].AxisY.Minimum = min;
                    }
                    target_graph.Series[0].XValueType = ChartValueType.Date;
                    target_graph.Series[0].XValueMember = "date";
                    target_graph.Series[0].IsXValueIndexed = true;
                    target_graph.Series[0].YValueMembers = "high,low,open,close";
                    target_graph.Series[0].CustomProperties = "PriceDownColor=Blue,PriceUpColor=Red";
                    target_graph.Series[0]["OpenCloseStyle"] = "Triangle";
                    target_graph.Series[0]["ShowOpenClose"] = "Both";
                    target_graph.DataBind();

                }

            }
            catch (Exception ex) {
                Console.WriteLine("Item_grid_CellClick error");
                Console.WriteLine(ex);
            }

        }

        private void sim_result_grid_key(object sender, KeyEventArgs e) {
            try {
                if (e.KeyCode.Equals(Keys.Up) || e.KeyCode.Equals(Keys.Down)) {

                    Stock_var stock = new Stock_var();
                    marketdb DB = new marketdb();
                    stock.company_info = DB.get_company_info();

                    int rowIndex = sim_result_grid.CurrentRow.Index;
                    string target_code = sim_result_grid.Rows[rowIndex].Cells[0].Value.ToString();


                    if (EndDayFlag && StartDayFlag) {

                        stock.daily_data = DB.get_daily_price(stock.company_info.FirstOrDefault(x => x.Value == target_code).Key, StartDay, EndDay);
                        target_graph.Series[0].Name = sim_result_grid.Rows[rowIndex].Cells[0].Value.ToString();
                        target_graph.DataSource = stock.daily_data;
                        target_graph.Series[0].XValueType = ChartValueType.DateTime;
                        target_graph.Series[0].XValueMember = "date";
                        target_graph.Series[0].YValueMembers = "close";

                        target_graph.DataBind();

                        double min = Convert.ToDouble(stock.daily_data.AsEnumerable().Min(row => row["close"]));
                        double max = Convert.ToDouble(stock.daily_data.AsEnumerable().Max(row => row["close"]));

                        min = min * 0.8;
                        max = max * 1.2;

                        if (max != min) {
                            target_graph.ChartAreas[0].AxisY.Minimum = min;
                            target_graph.ChartAreas[0].AxisY.Maximum = max;
                        }

                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Item_grid_CellClick error");
                Console.WriteLine(ex);
            }

         }
        private void chart_AxisViewChanged(object sender, ViewEventArgs e) {

            if (sender.Equals(kospi_chart)) {
                kospi_chart.ChartAreas[0].RecalculateAxesScale();
            }
            //else if (sender.Equals(kosdaq_chart)) {
            //    kosdaq_chart.ChartAreas[0].RecalculateAxesScale();
            //}
            else if (sender.Equals(target_graph)) {
                target_graph.ChartAreas[0].RecalculateAxesScale();
            }
            else if (sender.Equals(default_graph)) {
                default_graph.ChartAreas[0].RecalculateAxesScale();
            }
            

        }


    }


}
