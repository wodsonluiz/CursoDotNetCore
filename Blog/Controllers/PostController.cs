using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        List<Post> listaPost = new List<Post>();

        public PostController()
        {
            Post p = new Post();

            p.Titulo = "Game of Thrones";
            p.Resumo = "Baixo";
            p.Categoria = "Série";
            listaPost.Add(p);

            ViewBag.Posts = listaPost;
        }

        public IActionResult Index()
        {
            return View(listaPost);
        }

        public IActionResult Novo()
        {
            return View();
        }

        public IActionResult AdicionaPost(Post novo)
        {
            listaPost.Add(novo);
            return View("Index", listaPost);
        }
    }
}