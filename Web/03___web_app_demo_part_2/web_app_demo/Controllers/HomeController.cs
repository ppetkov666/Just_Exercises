using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_app_demo.Controllers
{
    public class HomeController : Controller
    {
        // we will try different examples and that's why they will be commented 
        // if you want to try how they works just uncomment each example

        // Example 1
        //public string Index(string id, string name)
        //{
        //    //<trace enabled="true" pageOutput="false"/> - added in web.config 
        //    //can be checked on http://localhost/web_app_demo/trace.axd
        //    //and it is depending on RouteConfig.cs
        //    //return "test string" + id + Request.QueryString["name"]; 
        //    return "My name is " + name + " i am " + id + " years old";
        //    //return View();
        //}

        // Example 2
        //public ActionResult Index()
        //{
        //    ViewBag.Countries = new List<string>() { "Bulgaria", "Usa", "Spain", "Germany" };
        //    return View();
        //}

        //Example 3
        public ActionResult Index()
        {
            ViewData["Countries"] = new List<string>() { "Bulgaria", "Usa", "Spain", "Germany" };
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