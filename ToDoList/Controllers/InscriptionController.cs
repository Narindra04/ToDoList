using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class InscriptionController : Controller
    {
        // GET: Inscription
        [HttpGet]
        public ActionResult Inscription()
        {
            return View();
        }

        //Post: Inscription
        [HttpPost]
        public ActionResult Inscription(Utilisateur utilisateur)
        {
            return RedirectToRoute("Home");
        }
    }
}