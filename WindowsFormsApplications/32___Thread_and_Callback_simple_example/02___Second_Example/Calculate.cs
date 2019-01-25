using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02___Second_Example
{
    public class Calculate
    {
        readonly int _number;
        Label lbl_count;
        ProgressBar prb_loading;
        public Calculate(int num, Label label, ProgressBar progressBar)
        {
            this._number = num;
            this.lbl_count = label;
            this.prb_loading = progressBar;
        }
        public void CalculateSum()
        {
            int sum = 0;
            for (int i = 1; i <= _number; i++)
            {
                sum += i;
            }
            CallbackCalculate(sum);
            SetProgressbar(sum);
        }
        public void CallbackCalculate(int num)
        {
            lbl_count.Text = $"The sum of numbers is {num.ToString()}";
        }
        public void SetProgressbar(int num)
        {
            prb_loading.Value = 0;
            prb_loading.Maximum = num;
            for (int i = 0; i < num; i++)
            {
                prb_loading.Value += 1;
            }
        }
    }
}
