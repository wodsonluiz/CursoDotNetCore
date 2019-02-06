using Blog.Models;
using Blog.Models.Dao;
using Blog.Providers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        public PostController()
        {
        }

        public IActionResult Index()
        {
            using (BlogContext ctx = new BlogContext())
            {
                return ctx.Post.ToList();
            }
        }

        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdicionaPost(Post novo)
        {
            //listaPost.Add(novo);
            PostDao dao = new PostDao();
            dao.Adiciona(novo);

            return RedirectToAction("Index");
        }
    }
}