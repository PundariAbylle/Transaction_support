using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transaction3.Controllers
{
    public class SubReportABPController : Controller
    {

        public ActionResult SubreportABP()
        {
            return View();
        }

        //public ActionResult RedirectToSubreport()
        //{
        //    return RedirectToAction("SubreportABP");
        //}
    }
}