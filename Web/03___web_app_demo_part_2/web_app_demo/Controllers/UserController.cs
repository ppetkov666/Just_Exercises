
namespace web_app_demo.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using web_app_demo.Models;
    public class UserController : Controller
    {

        //Example 1
        //public ActionResult Details()
        //{
        //    User user = new User();
        //    user.UserName = "petko";
        //    user.Password = "petko123";
        //    user.Address = "Bulgaria, Stara Zagora, first street 1 entr 1 apt 1";
        //    user.Email = "petko@123.com";
        //    user.Town = "Stara Zagora";
        //
        //    return View(user);
        //}

        // Example 2
        public ActionResult Details(int id)
        {
            UserContext userContext = new UserContext();
            User user = userContext.Users.Single(x => x.UniqueNumber == id);

            return View(user);
        }
        
        public ActionResult Index()
        {
            UserContext userContext = new UserContext();
            List<User> users = userContext.Users.ToList();
            return View(users);
        }
    }
}