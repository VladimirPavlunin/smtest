using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StructureMapDemo.Services;

namespace StructureMapDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorker _worker;
        //private readonly IFaillingService _faillingService;

        public HomeController(IWorker worker, IFaillingService faillingService)
        {
            _worker = worker;
            _faillingService = faillingService;
        }

        public ActionResult Index()
        {
            _faillingService.Hey();
            _worker.DoWork();
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
    }
}