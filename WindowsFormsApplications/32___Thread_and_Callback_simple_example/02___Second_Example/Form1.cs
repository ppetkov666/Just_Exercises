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

namespace _02___Second_Example
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            //lbl_count.Text = "Calculation is proceeding...";
            int number = int.Parse(tb_number.Text);
            
            Thread thread = new Thread(() =>
            {
                Calculate calculateNum = new Calculate(number, lbl_count, prb_loading);
                Action action = calculateNum.CalculateSum;
                this.BeginInvoke(action);
            });
            thread.Start();
            lbl_count.Text = "Calculation is proceeding...";
            lbl_count.Refresh();
        }
    }
}
