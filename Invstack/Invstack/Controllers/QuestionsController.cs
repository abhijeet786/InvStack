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

       
        [Route("Question", Name = "QuesCustomRoute")]
        public ActionResult Index()
        {

            return View();
        }
        //tbl_Questions Obj_tbl_Ques
        public JsonResult SubmitQues(tbl_Questions Obj_Ques)
        {
            int user_id = Convert.ToInt32(Session["User_Id"].ToString());
            string emp_id = Session["Emp_Id"].ToString();
            var user_data = dbContext.tbl_UserDetails.Where(u => u.Id == user_id && u.Employee_Id == emp_id).FirstOrDefault<tbl_UserDetails>();
            var data = dbContext.Add_question(user_data.Id, user_data.Employee_Id, Obj_Ques.Title, Obj_Ques.Question, Obj_Ques.Question_Description, Obj_Ques.language, user_data.Id);
            if (data > 0)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("failure", JsonRequestBehavior.AllowGet);
            }
           
        }
        [HttpGet]
        [Route("Lang")]
        public JsonResult Getlang()
        {
            var Languages = dbContext.tbl_lang.ToList();
            return Json(Languages, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Single")]
        public JsonResult getSingleQues(int ID,string UserID)
        {
            var Question = dbContext.getSingleQuestion(ID, UserID);
            return Json(Question, JsonRequestBehavior.AllowGet);
        }
        

    }
}