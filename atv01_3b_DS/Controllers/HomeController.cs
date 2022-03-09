using atv01_3b_DS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace atv01_3b_DS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult frmCadastro()
        {
            return View();
        }

        public ActionResult About(modeloExemplo m)
        {
            ViewBag.Message = m.nome;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}