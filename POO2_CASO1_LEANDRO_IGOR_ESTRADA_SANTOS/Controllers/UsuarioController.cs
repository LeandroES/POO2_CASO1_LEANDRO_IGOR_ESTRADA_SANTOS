using POO2_CASO1_LEANDRO_IGOR_ESTRADA_SANTOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POO2_CASO1_LEANDRO_IGOR_ESTRADA_SANTOS.Controllers
{
    public class UsuarioController : Controller
    {

        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult loginform(FormCollection collection)
        {
            string email = collection.Get("email");
            string Password = collection.Get("Password");
            if (email == "srinickraj@gmail.com" && Password == "1234")
            {
                Response.Redirect("http://www.neerajcodesolutions.com");
            }
            else
            {
                ViewBag.Message = "Please enter valid Email ID and Password";

            }
            return View("Index");
        }

    }

}

