using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading;
using System.Data;
using System.Threading.Tasks;

namespace BackTesting{
    delegate Task task_delegate();  // void func1(void)
    partial class BACK_TEST_FORM {
        private async void item_grid_fill_call(  ) {

            var item_grid_fill_task = Task.Run(() => item_grid_fill() );
            await item_grid_fill_task;

        }
        private async void corr_calc_call() {

            sim_result_dict = new Dictionary<string, double>();

            var Calc_task = Task.Run(() => corr_calc());
            await Calc_task;

            Run_sim_Flag = false;
            corr_calc_btn.Enabled = true;
            
        }



    }
}
