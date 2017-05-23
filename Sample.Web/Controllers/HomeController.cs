using Sample.Web.Services;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContainer container;

        public HomeController(IContainer container)
        {
            this.container = container;
        }

        public ActionResult Index()
        {
            const string PARSER = "Another";
            var parser = this.container.GetInstance<ITextParser>(string.Format("{0}TextParser", PARSER));
            parser.Parse("");

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