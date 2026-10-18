using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yefer_ControlAcceso.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string CORREO, string CONTRASEÑA)
        {
            var daoUsuarios = new UsuarioDAO();
            var usuarioValidado = daoUsuarios.Login(CORREO, CONTRASEÑA);
            if (usuarioValidado == null)
            {
                ViewBag.Mensaje = "Correo o contraseña incorrectos";
                return View();
            }
            ViewBag.Mensaje = "Login exitoso. Bienvenido " +
                              usuarioValidado.APELLIDOS + " " + usuarioValidado.NOMBRES;
            return View();

        }
    }
}