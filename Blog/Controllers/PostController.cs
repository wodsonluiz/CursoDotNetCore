using Blog.Models;
using Blog.Models.Dao;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        public PostController()
        {
        }

        public IActionResult Index()
        {
            PostDao dao = new PostDao();
            return View(dao.Lista());
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionaPost(Post novo)
        {
            if (ModelState.IsValid)
            {
                //listaPost.Add(novo);
                PostDao dao = new PostDao();
                dao.Adiciona(novo);

                return RedirectToAction("Index");
            }
            else
            {
                Post post = new Post();
                return View("Novo", post);
            }
        }

        [HttpGet]
        public IActionResult Categoria([Bind(Prefix = "Id")]string categoria)
        {
            PostDao dao = new PostDao();
            return View("Index", dao.BuscaCategoria(categoria));
        }

        public IActionResult RemovePost(int id)
        {
            PostDao dao = new PostDao();
            dao.Remove(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditaPost(Post post)
        {
            if (ModelState.IsValid)
            {
                PostDao dao = new PostDao();
                dao.Atualiza(post);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Visualiza", post);
            }
        }

        [HttpGet]
        public IActionResult Visualiza(int id)
        {
            PostDao dao = new PostDao();
            Post post = dao.FindPost(id);

            return View("Visualiza", post);
        }

        public IActionResult PublicaPost(int id)
        {
            PostDao dao = new PostDao();
            dao.Publica(id);
            return RedirectToAction("Index");
        }
    }
}