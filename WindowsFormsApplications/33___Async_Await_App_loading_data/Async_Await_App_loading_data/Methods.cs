

namespace Async_Await_App_loading_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class Methods
    {
        public static List<WebsiteDataModel> RunDownloadSync(ColorProgressBar.ColorProgressBar prb_loading)
        {
            List<string> webPages = Preparedata();

            prb_loading.Visible = true;
            prb_loading.BarColor = Color.FromArgb(255, 128, 255);
            prb_loading.Maximum = webPages.Count;
            prb_loading.Value = 0;
            prb_loading.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Dashed;

            List<WebsiteDataModel> output = new List<WebsiteDataModel>();

            foreach (var webpage in webPages)
            {
                prb_loading.Invoke((MethodInvoker)delegate
                {
                    prb_loading.Value += 1;
                    prb_loading.Refresh();
                });

                WebsiteDataModel result = DownloadWebContent(webpage);
                output.Add(result);
            }
            return output;
        }

        public static List<WebsiteDataModel> RunDownloadParallelSync()
        {
            List<string> webPages = Preparedata();

            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            // it works Syncroniously JUST executes the foreach in as many thread as there are processors available
            Parallel.ForEach<string>(webPages, (site) =>
             {
                 WebsiteDataModel result = DownloadWebContent(site);
                 output.Add(result);
             });
            return output;
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadAsync(/*IProgress<ProgressReportModel> progress,*/ColorProgressBar.ColorProgressBar prb_loading, BackgroundWorker bw, CancellationToken cancellationToken)
        {
            List<string> webPages = Preparedata();
            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            ProgressReportModel report = new ProgressReportModel();
            prb_loading.Maximum = 100;
            prb_loading.Value = 0;
            prb_loading.BarColor = Color.Aqua;
            prb_loading.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;

            foreach (var webpage in webPages)
            {
                WebsiteDataModel result = await Task.Run(() => DownloadWebContentAsync(webpage));
                output.Add(result);

                // this is not nessesary but i want to point it out as a option 
                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }

                report.WebPagesDownloaded = output;
                report.PercentCompleted = (output.Count * 100) / webPages.Count;
                bw.ReportProgress(report.PercentCompleted, report);

                // when we REPORT the progress it will raise ProgressChanged event and will call the methods
                // who are attached
                //if (progress != null)
                //{
                //    progress.Report(report);
                //}
            }

            return output;
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadParallelAsync()
        {
            List<string> webPages = Preparedata();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (var webpage in webPages)
            {
                tasks.Add(DownloadWebContentAsync(webpage));
            }
            WebsiteDataModel[] output = await Task.WhenAll(tasks);

            return new List<WebsiteDataModel>(output);
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadParallelASyncV2(ColorProgressBar.ColorProgressBar prb_loading, BackgroundWorker bw)
        {
            List<string> webPages = Preparedata();
            ProgressReportModel report = new ProgressReportModel();
            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            prb_loading.Maximum = 100;
            prb_loading.Value = 0;
            prb_loading.BarColor = Color.BurlyWood;
            prb_loading.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Dashed;

            await Task.Run(() =>
            {
                Parallel.ForEach<string>(webPages, (site) =>
                {
                    WebsiteDataModel result = DownloadWebContent(site);
                    lock (output)
                    {
                        output.Add(result);
                        report.PercentCompleted = (output.Count * 100) / webPages.Count;
                        report.WebPagesDownloaded = output;
                        bw.ReportProgress(report.PercentCompleted, report);
                    }

                });
            });
            return output;
        }

        private static List<string> Preparedata()
        {
            List<string> listOfWebsites = new List<string>();

            listOfWebsites.Add("https://www.google.com");
            listOfWebsites.Add("https://www.microsoft.com");
            listOfWebsites.Add("https://www.github.com");
            listOfWebsites.Add("https://www.stackoverflow.com");
            listOfWebsites.Add("https://www.yahoo.com");
            listOfWebsites.Add("https://www.amazon.com");
            return listOfWebsites;
        }

        private static WebsiteDataModel DownloadWebContent(string webPage)
        {
            WebsiteDataModel webData = new WebsiteDataModel();
            WebClient webclient = new WebClient();
            webData.WebsiteUrl = webPage;
            webData.WedSiteData = webclient.DownloadString(webPage);
            return webData;
        }

        private static async Task<WebsiteDataModel> DownloadWebContentAsync(string webPage)
        {
            WebsiteDataModel webData = new WebsiteDataModel();
            WebClient webclient = new WebClient();
            webData.WebsiteUrl = webPage;
            webData.WedSiteData = await webclient.DownloadStringTaskAsync(webPage);
            return webData;
        }
    }
}
