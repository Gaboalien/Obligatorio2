using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DominioPosta;

namespace AppMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PerformLogin(string username, string password)
        {
            Usuario usu = Almacen.Instancia.BuscarUsuario(username, password);

            if (usu == null)
            {
                ViewBag.ErrMsg = "No existe el usuario!";
                return View("Index");
            }
            else
            {
                Session["usuarioLogueado"] = usu;
                // Están al revés los parámetros! (Acción, Controlador)
                return RedirectToAction("Index", "Home");
            }

        }
    }
}