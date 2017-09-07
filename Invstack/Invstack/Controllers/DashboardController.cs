using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Invstack.Models;
namespace Invstack.Controllers
{

    public class DashboardController : Controller
    {
        StackEntities dbContext = new StackEntities();

        [Route("Home", Name = "Dashboard")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("getQues")]
        public JsonResult getTopQues()
        {
            var Ques = dbContext.getQuestion();
            return Json(Ques, JsonRequestBehavior.AllowGet);
        }
    }
}