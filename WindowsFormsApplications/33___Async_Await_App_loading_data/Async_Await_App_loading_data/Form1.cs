namespace Async_Await_App_loading_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_execute_sync_Click(object sender, EventArgs e)
        {
            ListBoxClear(); 
            Stopwatch watch = Stopwatch.StartNew();
            // these are two different options
            // the first one is with Parallel ForEach
            //List<WebsiteDataModel> result = Methods.RunDownloadParallelSync();
            // the second option is with normal foreach 
            List<WebsiteDataModel> result = Methods.RunDownloadSync(prb_my_custom_loading);
            PrintResults(result);

            watch.Stop();
            Int64 elapsedTimeInMiliSec = watch.ElapsedMilliseconds;
            listBox1.Items.Add($"Total execution time: {elapsedTimeInMiliSec}");   
        }

        private async void Btn_async_execute_Click(object sender, EventArgs e)
        {
            ListBoxClear();
            string text = btn_async_execute.Text;
            ButtonLock(btn_async_execute);
            cts.Dispose();
            cts = new CancellationTokenSource();

            Stopwatch watch = Stopwatch.StartNew();
            // because of the purpose of this task i practice to handle the progress  in the background with default
            // BackgroundWorker and with another Progress class. If you want to see the behavior of the other Progress you just 
            // have to uncomment the code related with the instance of this class
            try
            {
                List<WebsiteDataModel> result = await Methods.RunDownloadAsync(/*progress,*/prb_my_custom_loading, backgroundWorker1, cts.Token);
                PrintResults(result);
            }
            catch (OperationCanceledException)
            {                
                listBox1.Items.Add($"The operation was cancelled!");
            }

            watch.Stop();
            Int64 elapsedTimeInMiliSec = watch.ElapsedMilliseconds;
            listBox1.Items.Add($"Total execution time: {elapsedTimeInMiliSec}");
            
            ButtonLock(btn_async_execute, text);
        }

        private async void Btn_parallel_async_Click(object sender, EventArgs e)
        {
            ListBoxClear();
            string text = btn_parallel_async.Text;
            ButtonLock(btn_parallel_async);
            prb_my_custom_loading.Maximum = 100;
            prb_my_custom_loading.Value = 0;

            Stopwatch watch = Stopwatch.StartNew();

            // here i also implemented 2 diff options: parallell foreach 
            List<WebsiteDataModel> result = await Methods.RunDownloadParallelASyncV2(prb_my_custom_loading,backgroundWorker1);
            // and adding all async tasks into a list of tasks. and executed them
            //List<WebsiteDataModel> result = await Methods.RunDownloadParallelAsync();
            PrintResults(result);

            watch.Stop();
            long elapsedTimeInMiliSec = watch.ElapsedMilliseconds;
            listBox1.Items.Add($"Total execution time: {elapsedTimeInMiliSec}");
            ButtonLock(btn_parallel_async, text);
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
            ProgressReportModel prm = (ProgressReportModel)e.UserState;
            PrintResults(prm.WebPagesDownloaded);

        }

        private void Progress_ProgressChanged(object sender, ProgressReportModel e)
        {
            PrintResults(e.WebPagesDownloaded);
        }

        private void ButtonLock(Button button, string text ="")
        {
            if (button.Enabled == true)
            {
                button.Enabled = false;
                button.Text = "LOADING...Please Wait...";
            }
            else
            {
                button.Enabled = true;
                button.Text = text;
            }
        }

        private void ListBoxClear()
        {
            listBox1.Items.Clear();
            listBox1.Refresh();
        }
    }
}
