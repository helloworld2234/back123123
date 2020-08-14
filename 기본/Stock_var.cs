using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlX.XDevAPI.Relational;

namespace BackTesting {
    class Stock_var {
        public Dictionary<string, string> company_info = new Dictionary<string, string>();

        public DataTable daily_data = new DataTable();
        public DataRow daily_data_row = null;

        public DataTable min_data = new DataTable();
        public DataRow min_data_row = null;

        public Stock_var() {

            //일봉 데이터 테이블 col 추가 
            daily_data.Columns.Add(new DataColumn("date", typeof( DateTime )  ) )  ; // 단위 : 일
            daily_data.Columns.Add(new DataColumn("open", typeof(int) ) );              // 시가
            daily_data.Columns.Add(new DataColumn("high", typeof(int)));                // 고가
            daily_data.Columns.Add(new DataColumn("low", typeof(int)));                 // 저가
            daily_data.Columns.Add(new DataColumn("close", typeof(int)));               // 종가
            daily_data.Columns.Add(new DataColumn("diff", typeof(int)));                 // 변동량
            daily_data.Columns.Add(new DataColumn("volume", typeof(int)));           // 거래량

            //분 데이터 테이블 col 추가
            min_data.Columns.Add(new DataColumn("date", typeof(DateTime))); // 단위 : 일(day)     
            min_data.Columns.Add(new DataColumn("time", typeof(TimeSpan)) ) ; // 단위 : 분(min)    
            min_data.Columns.Add(new DataColumn("closing", typeof(int)));         // 1분 종가
            min_data.Columns.Add(new DataColumn("diff", typeof(int)));              // 시가 대비 변동량
            min_data.Columns.Add(new DataColumn("volume", typeof(int)));         //  분 거래량 
            min_data.Columns.Add(new DataColumn("variable_volume", typeof(int))); // 분 거래량 변동(미분)
    
            

        }
    }
}
