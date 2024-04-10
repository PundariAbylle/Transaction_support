using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transaction3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DisplayReport(string aaa)
        {
            string reportPath = "";

            if (aaa == "Transaction")
            {
                reportPath = "Transacion Analysis.rdl";
            }
            else if (aaa == "sales")
            {
                reportPath = "sales-order-detail.rdl";
            }

            ViewBag.ReportPath = "~/Resources/" + reportPath;

            return View();
        }
        public ActionResult Sales()
        {
            return View();
        }

        public ActionResult Transaction()
        {
            return View();
        }
        public ActionResult See()
        {
            return View();
        }
        public ActionResult InvoiceTransaction()
        {
            return View();
        }
    }
}