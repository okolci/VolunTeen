using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VolunTeen.Models;

namespace VolunTeen.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public ActionResult Index()
        {
            SDBHanlde dbhandle = new SDBHanlde();
            ModelState.Clear();
            return View(dbhandle.GetOpp());
        }
                
    }
}