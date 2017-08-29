using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Invstack.Models;

namespace Invstack.Controllers
{
    public class QuestionsController : Controller
    {

        StackEntities dbContext = new StackEntities();

        //
        // GET: /Questions/
        public ActionResult Index()
        {
            return View();
        }
        //tbl_Questions Obj_tbl_Ques
       public void SubmitQues(tbl_Questions Obj_Ques)
        {
         
        }
        
	}
}