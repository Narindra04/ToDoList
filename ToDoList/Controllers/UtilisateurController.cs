using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class UtilisateurController : Controller
    {
        // GET: Inscription
        public ActionResult Index()
        {
            return View();
        }
    }
}