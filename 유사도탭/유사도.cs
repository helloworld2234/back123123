using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BackTesting {
    partial class BACK_TEST_FORM {

        public DateTime StartDay;
        public DateTime EndDay;

        public bool StartDayFlag = false;
        public bool EndDayFlag = false;

        public bool defaultcodeFlag = false;
        public bool Run_sim_Flag = false;
        private string default_code = null;
        public Dictionary<string, double> sim_result_dict = new Dictionary<string, double>();

        public void item_grid_fill() {

            try {

                Stock_var stock = new Stock_var();
                marketdb DB = new marketdb();
                string item_search_str = sim_search_text.Text;

                stock.company_info = DB.get_company_info_search(item_search_str); // 검색 버튼을 눌렀을 경우 item_search_str을 정해줌

                foreach (KeyValuePair<string, string> pair in stock.company_info) {
                    sim_item_grid.Rows.Add(pair.Key, pair.Value);   //  ui를 건드리므로, invoke씀
                }

            }
            catch {
                return;
            }

        }
        public void corr_calc() {

            Run_sim_Flag = true;

            Stock_var d_stk = new Stock_var();
            marketdb dtw_db = new marketdb();
            Stock_var tar_stk = new Stock_var();
            //double[] d_pip = null;
            //double[] t_pip = null;

            //int pip_len;
            int pct = 0;
            int bar_cnt = 0;
            double result = 0;
            
            d_stk.company_info = dtw_db.get_company_info();
            d_stk.daily_data = dtw_db.get_daily_price(default_code, StartDay, EndDay);

            object[] d_stk_arr = d_stk.daily_data.Select().Select(x => x["close"]).ToArray();
            int[] d_stk_arr_int = d_stk_arr.Cast<int>().ToArray();
            double[] d_stk_arr_Scaling = Normalization.FeatureScaling(d_stk_arr_int);


            //pip_len = d_stk_arr_Scaling.Length < 700 ? 100 :
            //   d_stk_arr_Scaling.Length < 250 ? 75 :
            //   d_stk_arr_Scaling.Length < 120 ? 60 :
            //   d_stk_arr_Scaling.Length < 100 ? 50 :
            //   d_stk_arr_Scaling.Length < 60 ? 30 : 30;
            //Console.WriteLine(pip_len);




            //d_pip = Representation.PIP_VD(d_stk_arr_Scaling, pip_len);

            Parallel.ForEach(d_stk.company_info, cur_info => {
                try {
                    tar_stk.daily_data = dtw_db.get_daily_price(cur_info.Key, StartDay, EndDay);
                    object[] t_stk_arr = tar_stk.daily_data.Select().Select(x => x["close"]).ToArray();

                    int[] t_stk_arr_Int = t_stk_arr.Cast<int>().ToArray();
                    double[] t_stk_arr_Scaling = Normalization.FeatureScaling(t_stk_arr_Int);
                    //t_pip = Representation.PIP_VD(t_stk_arr_Scaling, pip_len);

                    result = SimilarityMeasure.corr(d_stk_arr_Scaling, t_stk_arr_Scaling);
                    //result = SimilarityMeasure.corr(d_pip, t_pip);
                    //result = SimilarityMeasure.GetDynamicTimeWarpDistance(d_pip, t_pip);
                    if (result > 0.89) {
                        sim_result_dict.Add(cur_info.Value, result);

                        if (InvokeRequired) {
                            Invoke(new Action(delegate () {
                                sim_result_grid.Rows.Add(cur_info.Value, sim_result_dict[cur_info.Value] );
                            }));
                        }

                    }


                    pct = ((++bar_cnt * 100) / d_stk.company_info.Count);
                    if (pct >= 100) {
                        pct = 100;
                    }
                    if (InvokeRequired) {
                        Invoke(new Action(delegate () {
                            sim_bar.Value = pct;
                        }));
                    }
                   
                           
                }
                catch {
                    ++bar_cnt;
                }
            });

            //foreach (KeyValuePair<string, double> pair in sim_result_dict ) {
            //    sim_result_grid.Rows.Add(pair.Key, pair.Value);
            //}
            
        }
       
    }
}

