using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncProgressBar
{
    public partial class Form1 : Form
    {
        WebClient test = new WebClient();
        CancellationTokenSource myToken;
        Progress<int> myprogress;
        int Counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Counter = 0;
            myToken = new CancellationTokenSource();
            await startProcessBar(myToken);
        }
        private void ReportProgress(int myInt)
        {
            label1.Text = "Download " + myInt.ToString();
            progressBar1.Value = myInt;
        }

        private async Task startProcessBar(CancellationTokenSource myToken)
        {
            Action<int> progressTarget = new Action<int>(ReportProgress);
            myprogress = new Progress<int>(progressTarget);
            for (int i = 0; i < 10; i++)
            {
                if (myToken.IsCancellationRequested)
                {
                    return;
                }
                string myString = await RetriveString(myprogress);
            }
        }
        private async Task<string> RetriveString(IProgress<int> myprogress)
        {
            string myString = "";
            if (myprogress != null)
            {
                Counter = Counter + 10;
                myprogress.Report(Counter);
            }
            test.DownloadFile("https://softuni.bg/", "D:\\target_file.txt");
            myString = await test.DownloadStringTaskAsync("https://softuni.bg/");
            return myString;
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (myToken != null)
            {
                myToken.Cancel();
            }
        }
    }
}
