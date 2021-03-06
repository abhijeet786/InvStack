﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Invstack.Models;
namespace Invstack.Controllers
{
    
    public class LoginController : Controller
    {
        StackEntities dbContext = new StackEntities();
        //
        // GET: /Login/
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [Route("Login")]
        public JsonResult LoginUser(tbl_UserDetails Obj_Login)
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
           var data = dbContext.tbl_UserDetails.Where(s => s.Employee_Id == Obj_Login.Employee_Id && s.Password == Obj_Login.Password).FirstOrDefault<tbl_UserDetails>();
           if(data != null)
           {
               Session["User_Id"] = data.Id;
               Session["Emp_Id"] = data.Employee_Id;
               Session["Username"] = data.Username;
           }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        
    }
}