using System;
using System.Collections.Generic;

namespace PictureSaver
{
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.IO;
    using System.Threading;
    using System.Net;
    using System.Xml;

    public partial class PicSvrFrm : Form
    {
        private WebClient client;
        private Queue<string> queueFiles;
        private string fileNameFinal;

        public PicSvrFrm()
        {
            InitializeComponent();
        }

        private bool ValidateUrl(string url)
        {
            char[] unacceptionals = new char[3] { '\\', '/', ' ' };

            if (url.StartsWith("\\") || url.StartsWith("/") || url.StartsWith(" "))
            {
                url = url.TrimStart(unacceptionals);
            }
            else if (url.EndsWith("\\") || url.EndsWith(" "))
            {
                url = url.TrimEnd(unacceptionals);
            }

            else if (!url.Contains('.'))
            {
                MessageBox.Show("Invalid Url!");
                return false;
            }
            return true;
        }

        private List<string> ParseHtml(string url)
        {
            //https://www.kinoarena.com
            int first;
            int last;
            string tag = string.Empty;
            List<string> tags = new List<string>();
            string htmlString = string.Empty;
            try
            {
                htmlString = client.DownloadString(url);
            }
            catch (WebException)
            {
                MessageBox.Show("Address cannot be accessed or does not exist!");
                return tags;
            }
            for (int i = 0; i < htmlString.Length; i++)
            {
                first = htmlString.IndexOf("<img", i);
                if (first < 0)
                    break;
                last = htmlString.IndexOf('>', first);
                tag = htmlString.Substring(first, last - first + 1);
                if (tag.Contains("http"))
                {
                    tags.Add(tag);
                }
                i = last;
            }
            return tags;
        }

        private Queue<string> ParseImageTags(List<string> imagTags)
        {
            int first;
            int last;
            string imgUrl = string.Empty;
            Queue<string> imageUrls = new Queue<string>();

            //for (int i = 0; i < imagTags.Count - 1; i++)
            //{
            //    if (imagTags[i].Contains("http"))
            //    {
            //        first = imagTags[i].IndexOf("http");
            //        if (imagTags[i][first - 1] == '\"')
            //        {
            //            last = imagTags[i].IndexOf("\"", first);
            //        }
            //        else if (imagTags[i][first - 1] == '\'')
            //        {
            //            last = imagTags[i].IndexOf("\'", first);
            //        }
            //        else
            //        {
            //            last = imagTags[i].LastIndexOf(".");
            //            last = last + 4;
            //        }
            //        imgUrl = imagTags[i].Substring(first, last - first);
            //    }
            //    imageUrls.Enqueue(imgUrl);
            //}

            foreach (string imgTag in imagTags)
            {
                int startIndex = imgTag.IndexOf("src=");
                //<img  class="lazyOverHome" data-original=
                //"http://m3.netinfo.bg/media/images/26151/26151085/130-130-iaponka.jpg" src="" width="130" height="130" alt="РЇРїР...

                if (imgTag.Contains("http") && /*DOBAVKA*/(imgTag.IndexOf("http") > startIndex)/*DOBAVKA*/)
                {
                    try
                    {
                        first = imgTag.IndexOf('\"', startIndex);
                        imgUrl = imgTag.Remove(0, first + 1);
                        last = imgUrl.IndexOf('\"');
                        imgUrl = imgUrl.Remove(last, imgUrl.Length - last);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    if (Path.HasExtension(imgUrl))//DOBAVKA
                    {
                        imageUrls.Enqueue(imgUrl);
                    }
                }
                else
                {
                    continue;
                }//DOBAVKA
            }
            return imageUrls;
        }
        private void SvDlBtn_Click(object sender, EventArgs e)
        {
            client = new WebClientWithTimeout();
            string urlInTb = LnkTb.Text;
            DialogResult res = FldrDlg.ShowDialog();
            if (res != DialogResult.OK)
            {
                return;
            }
            //vuv func - bool validateUrl(string url)
            if (!ValidateUrl(urlInTb))
            {
                return;
            }

            if (!urlInTb.StartsWith("http"))
            {
                try
                {
                    urlInTb = new UriBuilder(urlInTb).Uri.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Url!");
                    return;
                }
            }

            List<string> imagesTags = ParseHtml(urlInTb);
            if (imagesTags.Count == 0)
            {
                MessageBox.Show("Page does not contain any Images");
                return;
            }
            queueFiles = ParseImageTags(imagesTags);
            AlFlsPrgBr.Maximum = queueFiles.Count;
            AlFlsPrgBr.Value = 0;
            StartDownloading();
        }
        private string GetFileName(string imageUrl)
        {
            int question = imageUrl.IndexOf('?');
            if (imageUrl.Contains('?'))
            {
                imageUrl = imageUrl.Remove(question);
            }
            string fileName = FldrDlg.SelectedPath + "\\" + Path.GetFileName(imageUrl);
            string ext = Path.GetExtension(fileName);
            int incresement = 0;
            while (File.Exists(fileName))
            {
                fileName = FldrDlg.SelectedPath + "\\" + Path.GetFileNameWithoutExtension(imageUrl) + "(" + incresement + ")" + ext;
                incresement++;
            }
            fileNameFinal = fileName;
            return fileName;
        }

        private void StartDownloading()
        {
            SvDlBtn.Enabled = false;
            client = new WebClient();
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            NextFile();
        }
        private void NextFile()
        {
            if (queueFiles.Count == 0)
            {
                MessageBox.Show("Download Complete!");
                SvDlBtn.Enabled = true;
                return;
            }
            AlFlsPrgBr.Value = AlFlsPrgBr.Value + 1;
            string imageUrl = queueFiles.Dequeue();
            string fileName = GetFileName(imageUrl);
            client.DownloadFileAsync(new Uri(imageUrl), fileName);
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            OneFlPrgBr.Value = e.ProgressPercentage;
            FileNmLbl.Text = Path.GetFileName(fileNameFinal) + "   " + OneFlPrgBr.Value.ToString() + "% Completed";
            FilePrgsLbl.Text = AlFlsPrgBr.Value.ToString() + " / " + AlFlsPrgBr.Maximum.ToString() + " Files Downloaded";
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            NextFile();
        }

        private void PicSvrFrm_Load(object sender, EventArgs e)
        {

        }

        private void AlFlsPrgBr_Click(object sender, EventArgs e)
        {

        }
    }
    public class WebClientWithTimeout : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest wr = base.GetWebRequest(address);
            wr.Timeout = 5000;
            return wr;
        }
    }
}