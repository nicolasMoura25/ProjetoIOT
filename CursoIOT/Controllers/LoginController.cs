using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoIOT.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if(ViewBag.nome == "Nicolas" && ViewBag.senha == "senha1")
            {

            }
                         
            return View();
        }
    }
}