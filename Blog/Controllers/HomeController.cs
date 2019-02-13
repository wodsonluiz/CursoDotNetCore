using Blog.Models;
using Blog.Models.Dao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private PostDao db;

        public HomeController(PostDao _db)
        {
            this.db = _db;
        }

        public IActionResult Index()
        {
            List<Post> list = db.ListaPost();
            return View(list);
        }

        public IActionResult Busca(string termo)
        {
            IList<Post> list = db.ListaPeloTermo(termo);
            return View("Index", list);
        }
    }
}