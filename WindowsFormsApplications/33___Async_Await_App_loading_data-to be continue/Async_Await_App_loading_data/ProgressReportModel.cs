namespace Async_Await_App_loading_data
{
    using System.Collections.Generic;
    public class ProgressReportModel
    {
        public int PercentCompleted { get; set; } = 0;
        public List<WebsiteDataModel> WebPagesDownloaded { get; set; } = new List<WebsiteDataModel>();
    }
}
