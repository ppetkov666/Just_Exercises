using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04___Reading_from_file_with_Background_worker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            bgw_worker.RunWorkerAsync();
            lbl_count.Text = "You Request is processed. Please wait...";
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            bgw_worker.CancelAsync();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("D:\\file_counter.txt"))
            {
                string fullContent = reader.ReadToEnd();
                count = fullContent.Length;
                Thread.Sleep(1000);
            }
            return count;
        }
        private void SetLabelText(int counter)
        {
            lbl_count.Text = counter.ToString() + " characters in file";
        }
        private void SetLabelpercentage(int counter)
        {
            lbl_percentage.Text = $"{counter.ToString()} %";
        }
        private void SetProgressBar(int counter)
        {
            for (int i = 0; i <= 100; i++)
            {
                prb_FileCounter.Value = counter;
            }
        }

        private void Bgw_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = CountCharacters();
            e.Result = count;
            for (int i = 1; i <= 100; i++)
            {
                if (bgw_worker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    Thread.Sleep(20);
                    bgw_worker.ReportProgress(i);
                }

            }

        }

        private void Bgw_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SetProgressBar(e.ProgressPercentage);
            SetLabelpercentage(e.ProgressPercentage);
        }

        private void Bgw_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbl_count.Text = $"You have just canceled the operation";
            }
            else
            {
                lbl_count.Text = $"{e.Result} characters in file";
            }
        }


    }
}
