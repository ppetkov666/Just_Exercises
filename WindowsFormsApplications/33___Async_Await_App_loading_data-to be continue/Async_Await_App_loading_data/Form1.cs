using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_Await_App_loading_data
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_execute_sync_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Refresh();
            Stopwatch watch = Stopwatch.StartNew();
            // these are two different options
            List<WebsiteDataModel> result = Methods.RunDownloadParallelSync(prb_my_custom_loading);

            //List<WebsiteDataModel> result = Methods.RunDownloadSync(prb_my_custom_loading);
            PrintResults(result);

            watch.Stop();
            Int64 elapsedTimeInMiliSec = watch.ElapsedMilliseconds;
            listBox1.Items.Add($"Total execution time: {elapsedTimeInMiliSec}");
        }
        private async void Btn_async_execute_Click(object sender, EventArgs e)
        {
            

            listBox1.Items.Clear();
            listBox1.Refresh();
            prb_my_custom_loading.Maximum = 100;

            Stopwatch watch = Stopwatch.StartNew();
            // because of the purpose of this task i practice to handle the progress  in the background with default
            // BackgroundWorker and with another Progress class .If you want to see the behavior of the other Progress you just 
            // have to uncomment the code related with the instance of this class
            try
            {
                List<WebsiteDataModel> result = await Methods.RunDownloadAsync(/*progress,*/ backgroundWorker1, cts.Token);
                PrintResults(result);
            }
            catch (OperationCanceledException)
            {
                listBox1.Items.Add($"The operation was cancelled!");

            }

            watch.Stop();
            Int64 elapsedTimeInMiliSec = watch.ElapsedMilliseconds;
            listBox1.Items.Add($"Total execution time: {elapsedTimeInMiliSec}");
        }

        private async void Btn_parallel_async_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Refresh();
            Stopwatch watch = Stopwatch.StartNew();


            //List<WebsiteDataModel> result = await Methods.RunDownloadParallelASyncV2();

            List<WebsiteDataModel> result = await Methods.RunDownloadParallelAsync();
            PrintResults(result);

            watch.Stop();
            long elapsedTimeInMiliSec = watch.ElapsedMilliseconds;
            listBox1.Items.Add($"Total execution time: {elapsedTimeInMiliSec}");
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }


        private void PrintResults(List<WebsiteDataModel> results)
        {
            listBox1.Items.Clear();
            foreach (var result in results)
            {
                listBox1.Items.Add($"{ result.WebsiteUrl } downloaded: { result.WedSiteData.Length } characters long.");
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prb_my_custom_loading.Value = e.ProgressPercentage;
            ProgressReportModel obj = (ProgressReportModel)e.UserState;
            PrintResults(obj.WebPagesDownloaded);

        }

        private void Progress_ProgressChanged(object sender, ProgressReportModel e)
        {
            PrintResults(e.WebPagesDownloaded);
        }
    }
}
