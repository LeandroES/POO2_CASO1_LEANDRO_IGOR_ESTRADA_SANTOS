using POO2_CASO1_LEANDRO_IGOR_ESTRADA_SANTOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace POO2_CASO1_LEANDRO_IGOR_ESTRADA_SANTOS.Controllers
{
    public class UsuarioController : Controller
    {

        // GET: Registration
        public ActionResult Reg()
        {

            return View();

        }
        public ActionResult SaveReg()
        {
           
       
            string sUsername = Request.Form["Username"];
            string sPassword = Request.Form["Password"];
            ViewBag.sUsername = sUsername;
            ViewBag.sPassword = sPassword;
            Session["username"] = sUsername;
            Session["password"] = sPassword;
            return View();

        }
        public ActionResult LoginPage()
        {
            return View();
        }
        public ActionResult Log()
        {
            string nUserName = Request.Form["UserName"];
            string nPassword = Request.Form["Password"];
            string sUsername = Session["username"].ToString();
            string sPassword = Session["password"].ToString();
            if (string.Compare(sUsername, nUserName) == 0 && string.Compare(sPassword, nPassword) == 0)
            {
                ViewBag.message = "login success";
            }
            else {
                ViewBag.message = "Login fail";
            }
            return View();
        }
    }
}


