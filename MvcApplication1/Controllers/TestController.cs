using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        //мы работаем в ветке 3
        // GET: /Test/

        public ActionResult Index()
        {
            //add some 
            return View();
        }

    }
}
