using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Models.Dao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blog.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDao dao;

        public UsuarioController(UsuarioDao _dao)
        {
            dao = _dao;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Autentica(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Usuario logado = dao.Busca(model.LoginName, model.Senha);

                if (logado != null)
                {
                    HttpContext.Session.SetString("usuario", JsonConvert.SerializeObject(logado));

                    return RedirectToAction("Index", "Post", new { area = "Admin" });
                }
                else
                {
                    ModelState.AddModelError("login.Invalido", "Login ou Senha Incorretos");
                }
            }

            return View("Login", model);
        }
    }
}