using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_await_task_code_behind_version_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_execute_sync_Click(object sender, EventArgs e)
        {
            lb_list_of_content.Items.Clear();
            Stopwatch watch = Stopwatch.StartNew();
            RunDownloadSync();
            watch.Stop();
            PrintTheTimeExecution(watch);
        }

        private async void Btn_execute_async_Click(object sender, EventArgs e)
        {
            lb_list_of_content.Items.Clear();
            Stopwatch watch = Stopwatch.StartNew();
            await RunDownloadAsync();

            watch.Stop();
            PrintTheTimeExecution(watch);
        }

        private async void btn_execute_parallel_Click(object sender, EventArgs e)
        {
            lb_list_of_content.Items.Clear();
            Stopwatch watch = Stopwatch.StartNew();
            await RunDownloadParallelAsync();

            watch.Stop();
            PrintTheTimeExecution(watch);
        }

        private async Task RunDownloadParallelAsync()
        {
            List<string> webpages = PrepareContent();
            SetProgressBar(webpages);
            List<Task<WebPageDataModel>> taskContentlist = new List<Task<WebPageDataModel>>();
            foreach (var page in webpages)
            {
                prb_loading.Value += 1;
                // both approaches does the same just i want to demonstrate how to proceed when we CAN'T change 
                // the method we operate with , and the second approach is when we could change it and make it Async
                taskContentlist.Add(Task.Run(() => DownloadWebPage(page)));
                //taskContentlist.Add(DownloadWebPageAsync(page));
            }
            WebPageDataModel[] results = await Task.WhenAll(taskContentlist);
            foreach (WebPageDataModel item in results)
            {
                ReportWebInfo(item);
            }
        }

        private async Task RunDownloadAsync()
        {
            List<string> webpages = PrepareContent();
            SetProgressBar(webpages);

            foreach (string page in webpages)
            {
                // it can be done in both ways: with or without instance ot Task
                //Task<WebPageDataModel> task = new Task<WebPageDataModel>(() => DownloadWebPage(page));
                //task.Start();
                prb_loading.Value += 1;
                WebPageDataModel model = await Task.Run(()=> DownloadWebPage(page));
                ReportWebInfo(model);
            }
        }

        private void RunDownloadSync()
        {
            List<string> webpages = PrepareContent();
            SetProgressBar(webpages);
            foreach (string page in webpages)
            {
                prb_loading.Value += 1;
                WebPageDataModel model = DownloadWebPage(page);
                ReportWebInfo(model);
            }
        }

        private List<string> PrepareContent()
        {
            List<string> webPages = new List<string>();

            lb_list_of_content.Items.Clear();

            webPages.Add("https://www.google.com");
            webPages.Add("https://www.amazon.com");
            webPages.Add("https://www.yahoo.com");
            webPages.Add("https://www.microsoft.com");

            return webPages;
        }
        private WebPageDataModel DownloadWebPage(string page)
        {
            WebPageDataModel model = new WebPageDataModel();
            WebClient client = new WebClient();
            model.WebPageURL = page;
            model.WebPageContent = client.DownloadString(page);
            return model;
        }
        private async Task<WebPageDataModel> DownloadWebPageAsync(string page)
        {
            WebPageDataModel model = new WebPageDataModel();
            WebClient client = new WebClient();
            model.WebPageURL = page;
            model.WebPageContent = await client.DownloadStringTaskAsync(page);
            return model;
        }

        private void ReportWebInfo(WebPageDataModel model)
        {
            lb_list_of_content.Items.Add($"The content of {model.WebPageURL} was downloaded. It contains {model.WebPageContent.Length} characters");
        }

        private void SetProgressBar(List<string> webpages)
        {
            prb_loading.Maximum = webpages.Count;
            prb_loading.Value = 0;
        }

        private void PrintTheTimeExecution(Stopwatch watch)
        {
            Int64 elapsedTimeInMs = watch.ElapsedMilliseconds;
            double elapsedInSec = elapsedTimeInMs / 1000.0;
            lb_list_of_content.Items.Add($"Total execution time is {elapsedTimeInMs}ms or {elapsedInSec} sec!");
        }

    }
}
