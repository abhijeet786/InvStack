using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invstack.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/
        [Route("Article",Name="ArticleCustomRoute")]
        public ActionResult Index()
        {
            return View();
        }
        //[Route("Comment")]
        //public JsonResult Comment()
        //{

        //}
	}
}