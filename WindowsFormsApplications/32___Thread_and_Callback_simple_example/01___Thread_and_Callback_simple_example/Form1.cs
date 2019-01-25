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

namespace Thread_and_Callback_simple_example
{
    public delegate void CalculateNumbers(int numbers);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            //lbl_count.Text = "Calculation is proceeding, please wait...";
            int number = int.Parse(tb_number.Text);

            
            //Thread thread = new Thread(new ThreadStart(calculateNum.CalculateSum));
            Thread thread = new Thread(() =>
            {
                CalculateNumbers callback = new CalculateNumbers(SetProgressbar);
                callback += CallbackCalculate;
                Calculate calculateNum = new Calculate(number, callback);
                Action action = calculateNum.CalculateSum;
                this.BeginInvoke(action);
            });
            thread.Start();
            lbl_count.Text = "Calculation is proceeding, please wait...";
            //lbl_count.Refresh();
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
