using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invstack.Controllers
{
  
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/
        
        [Route("Home")]
        public ActionResult Index()
        {
            return View();
        }
	}
}