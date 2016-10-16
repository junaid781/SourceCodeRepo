using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMSWebApp.Controllers
{
    public class ButtonsController : Controller
    {
        //
        // GET: /Buttons/
        
        public ActionResult Index()
        {
            return View();
        }
        /*
        public string Index()
        {
            return "This is the text for the buttons page";
        }*/
    }
}