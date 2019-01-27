

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


        public static List<WebsiteDataModel> RunDownloadParallelSync(ColorProgressBar.ColorProgressBar prb_loading)
        {
            List<string> webPages = Preparedata();

            prb_loading.Visible = true;
            prb_loading.BarColor = Color.FromArgb(255, 128, 255);
            prb_loading.Maximum = webPages.Count;
            prb_loading.Value = 0;
            prb_loading.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Dashed;

            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            // it works Syncronious  
            Parallel.ForEach<string>(webPages, (site) =>
             {
                 prb_loading.Invoke((MethodInvoker)delegate
                 {
                     prb_loading.Value += 1;
                     prb_loading.Refresh();
                 });

                 WebsiteDataModel result = DownloadWebContent(site);
                 output.Add(result);
             });
            return output;
        }



        public static async Task<List<WebsiteDataModel>> RunDownloadParallelASyncV2(ColorProgressBar.ColorProgressBar prb_loading)
        {
            List<string> webPages = Preparedata();

            prb_loading.Visible = true;
            prb_loading.BarColor = Color.FromArgb(255, 128, 255);
            prb_loading.Maximum = webPages.Count;
            prb_loading.Value = 0;
            prb_loading.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Dashed;

            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            // it works Syncronious  
            await Task.Run(() =>
           {
               Parallel.ForEach<string>(webPages, (site) =>
               {
                   prb_loading.Invoke((MethodInvoker)delegate
                   {
                       prb_loading.Value += 1;
                       prb_loading.Refresh();
                   });

                   WebsiteDataModel result = DownloadWebContent(site);
                   output.Add(result);
               });
           });
            return output;
        }





        public static async Task<List<WebsiteDataModel>> RunDownloadAsync(/*IProgress<ProgressReportModel> progress,*/ BackgroundWorker bw, CancellationToken cancellationToken)
        {
            List<string> webPages = Preparedata();
            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            ProgressReportModel report = new ProgressReportModel();

            foreach (var webpage in webPages)
            {
                WebsiteDataModel result = await Task.Run(() => DownloadWebContent(webpage));
                output.Add(result);

                cancellationToken.ThrowIfCancellationRequested();

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
            //prb_loading.Visible = true;
            //prb_loading.BarColor = Color.FromArgb(255, 128, 255);
            //prb_loading.Maximum = 100;
            //prb_loading.Value = 0;
            //prb_loading.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Dashed;
            foreach (var webpage in webPages)
            {
                tasks.Add(DownloadWebContentAsync(webpage));
            }
            WebsiteDataModel[] output = await Task.WhenAll(tasks);

            return new List<WebsiteDataModel>(output);
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
