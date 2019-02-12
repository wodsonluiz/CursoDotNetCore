using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Models.Dao;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PostDao db = new PostDao();
            List<Post> list = db.ListaPost();
            return View(list);
        }

        public IActionResult Busca(string termo)
        {
            PostDao dao = new PostDao();
            IList<Post> list = dao.ListaPeloTermo(termo);

            return View("Index", list);
        }
    }
}