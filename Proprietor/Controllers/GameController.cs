using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proprietor.Controllers
{
    

    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            if(Session["UserId"] != null)
            {

                return View();
            }
            return RedirectToAction("Index", "Home");
        }
    }

    
}