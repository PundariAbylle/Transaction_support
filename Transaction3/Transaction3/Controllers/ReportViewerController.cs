using BoldReports.Web.ReportViewer;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;


namespace Transaction3.Controllers
{
    public class ReportViewerController : ApiController, IReportController
    {
        // Post action for processing the RDL/RDLC report
        public object PostReportAction(Dictionary<string, object> jsonResult)
        {
            return ReportHelper.ProcessReport(jsonResult, this);
        }

        // Get action for getting resources from the report
        [System.Web.Http.ActionName("GetResource")]
        [System.Web.Mvc.AcceptVerbs("GET")]
        public object GetResource(string key, string resourcetype, bool isPrint)
        {
            return ReportHelper.GetResource(key, resourcetype, isPrint);
        }

        // Method that will be called when initialize the report options before start processing the report
        [System.Web.Mvc.NonAction]
        public void OnInitReportOptions(ReportViewerOptions reportOption)
        {
            // You can update report options here
        }

        // Method that will be called when reported is loaded
        [System.Web.Mvc.NonAction]
        public void OnReportLoaded(ReportViewerOptions reportOption)
        {
            //You can update report options here
        }


    }
}