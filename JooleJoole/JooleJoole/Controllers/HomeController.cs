using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleJoole.Models;

namespace JooleJoole.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search() => View();

        public ActionResult Test(int id)
        {
            dbConnection dbConnection = new dbConnection();
            Users user = dbConnection.Users.Single(usr => usr.UserRoleId == 3);
            return View(user);
        }
    }
}