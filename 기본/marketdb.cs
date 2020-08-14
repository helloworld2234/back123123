using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using System.Text;
using System.Data;
using MySqlX.XDevAPI.Relational;

namespace BackTesting {
    class marketdb{
        private string constr =;
 
        public Dictionary<string, string> get_company_info() {

            Dictionary<string, string> company_dict = new Dictionary<string, string>();
            using ( MySqlConnection conn = new MySqlConnection( this.constr ) ){
                
                try{
                    conn.Open(); 
                    string quary = "SELECT * FROM company_info";
                    MySqlCommand cmd = new MySqlCommand(quary, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read()) {
                        company_dict.Add(rdr["code"].ToString(), rdr["company"].ToString() );
                    }
                    conn.Close();
                }
                catch (Exception ex){

                    Console.WriteLine("연결 실패");
                    Console.WriteLine(ex.ToString());
                }
               
            }
            return company_dict;
        }
        public Dictionary<string, string> get_company_info_search(string search_name) {

            Dictionary<string, string> company_dict = new Dictionary<string, string>();
            using (MySqlConnection conn = new MySqlConnection(this.constr)) {

                try {
                    conn.Open(); Console.WriteLine("연결 성공");
                    string quary = "SELECT * FROM company_info where company LIKE '%"+ search_name + "%' ";
                    MySqlCommand cmd = new MySqlCommand(quary, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read()) {
                        company_dict.Add(rdr["code"].ToString(), rdr["company"].ToString());
                    }
                    conn.Close();
                }
                catch (Exception ex) {

                    Console.WriteLine("연결 실패");
                    Console.WriteLine(ex.ToString());
                }

            }
            return company_dict;
        }
        public DataTable get_daily_price(string code, DateTime startDate , DateTime endDate ) {
            
            Stock_var temp = new Stock_var();
            using (MySqlConnection conn = new MySqlConnection(this.constr)){
                
                try{
                    conn.Open(); 
                    //Console.WriteLine("연결 성공");
                    StringBuilder quary = new StringBuilder();
                    quary.Append("SELECT * FROM daily_price WHERE code = ");
                    quary.Append("'"+code +"' ");
                    quary.Append("and date >= ");
                    quary.Append("'" + startDate.ToString("yyyy-MM-dd") + "' ");
                    quary.Append("and date <=");
                    quary.Append("'" + endDate.ToString("yyyy-MM-dd") + "'");
                    //Console.WriteLine(quary.ToString());
                    
                    MySqlCommand cmd = new MySqlCommand(quary.ToString() , conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read()){
                        //Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}", rdr["date"] , rdr["open"], rdr["high"], rdr["low"], rdr["close"], rdr["diff"], rdr["volume"]);
                        temp.daily_data_row = temp.daily_data.NewRow();
                        temp.daily_data_row["date"] = rdr["date"];
                        temp.daily_data_row["open"] = rdr["open"];
                        temp.daily_data_row["high"] = rdr["high"];
                        temp.daily_data_row["low"] = rdr["low"];
                        temp.daily_data_row["close"] = rdr["close"];
                        temp.daily_data_row["diff"] = rdr["diff"];
                        temp.daily_data_row["volume"] = rdr["volume"];
                        temp.daily_data.Rows.Add(temp.daily_data_row);
                    }
                    conn.Close();
                }
                catch (Exception ex) {
                    Console.WriteLine("연결 실패");
                    Console.WriteLine(ex.ToString());
                }
            }
            return temp.daily_data;
        }


        // flag =  하루치 : True, 일주일 전 분봉 데이터 : False 
        public DataTable get_min_price(string code, DateTime defaultDate, bool flag){

            Stock_var temp = new Stock_var();
            using (MySqlConnection conn = new MySqlConnection(this.constr)){

                try {
                    conn.Open();
                    Console.WriteLine("연결 성공");
                    StringBuilder quary = new StringBuilder();
                    if (flag) {
                        quary.Append("SELECT * FROM preDay_min_price WHERE");
                        quary.Append(" ( code ='" + code + "'");
                        quary.Append(" AND date =");
                        quary.Append(" '"+ defaultDate.ToString("yyyy-MM-dd")+"')");
                        //Console.WriteLine(quary.ToString());
                    }
                    else{
                        quary.Append("SELECT * FROM preDay_min_price WHERE");
                        quary.Append(" code ='" + code + "'");
                        //Console.WriteLine(quary.ToString());
                    }

                    MySqlCommand cmd = new MySqlCommand(quary.ToString(), conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while ( rdr.Read() ){
                        //Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", rdr["date"] , rdr["time"], rdr["closing"], rdr["diff"], rdr["volume"], rdr["variable_volume"]);
                        temp.min_data_row = temp.min_data.NewRow();
                        temp.min_data_row["date"] = rdr["date"];
                        temp.min_data_row["time"] = rdr["time"];
                        temp.min_data_row["closing"] = rdr["closing"];
                        temp.min_data_row["diff"] = rdr["diff"];
                        temp.min_data_row["volume"] = rdr["volume"];
                        temp.min_data_row["variable_volume"] = rdr["variable_volume"];
                        temp.min_data.Rows.Add(temp.min_data_row);
                    }
                    conn.Close();
                }
                catch (Exception ex){
                    Console.WriteLine("연결 실패");
                    Console.WriteLine(ex.ToString());
                }
            }
            return temp.min_data;
        }


        public DataTable get_market_index(string market, DateTime startDate, DateTime endDate) {  
            //market : kospi 또는 kosdaq 를 string형태로 입력(소문자)

            Stock_var temp = new Stock_var();
            using (MySqlConnection conn = new MySqlConnection(this.constr)) {

                try {
                    conn.Open();
                    //Console.WriteLine("연결 성공");
                    StringBuilder quary = new StringBuilder();
                    quary.Append("SELECT * from "+ market + " WHERE DATE >= '"+ startDate.ToString("yyyy - MM - dd") + "' AND DATE<='" + endDate.ToString("yyyy-MM-dd") + "'");
   
                    MySqlCommand cmd = new MySqlCommand(quary.ToString(), conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read()) {
                        //Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}", rdr["date"] , rdr["open"], rdr["high"], rdr["low"], rdr["close"], rdr["diff"], rdr["volume"]);
                        temp.daily_data_row = temp.daily_data.NewRow();
                        temp.daily_data_row["date"] = rdr["date"];
                        temp.daily_data_row["open"] = rdr["open"];
                        temp.daily_data_row["high"] = rdr["high"];
                        temp.daily_data_row["low"] = rdr["low"];
                        temp.daily_data_row["close"] = rdr["close"];
                        temp.daily_data_row["diff"] = rdr["diff"];
                        temp.daily_data_row["volume"] = rdr["volume"];
                        temp.daily_data.Rows.Add(temp.daily_data_row);
                    }
                    conn.Close();
                }
                catch (Exception ex) {
                    Console.WriteLine("연결 실패");
                    Console.WriteLine(ex.ToString());
                }
            }
            return temp.daily_data;
        }




    }

}

 