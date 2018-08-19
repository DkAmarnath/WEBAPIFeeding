using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiFeeding.Controllers
{
    public class testController : ApiController
    {
        // GET: test
        public ActionResult Index()
        {
            return View();
        }
    }
}