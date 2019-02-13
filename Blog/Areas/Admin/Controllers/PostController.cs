using Blog.Models;
using Blog.Models.Dao;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostController : Controller
    {
        private PostDao dao;

        public PostController(PostDao _dao)
        {
            this.dao = _dao;
        }

        public IActionResult Index()
        {
            return View(dao.Lista());
        }

        [HttpGet]
        public IActionResult Novo()
        {
            Post p = new Post();
            return View(p);
        }

        [HttpPost]
        public IActionResult AdicionaPost(Post novo)
        {
            if (ModelState.IsValid)
            {
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
            return View("Index", dao.BuscaCategoria(categoria));
        }

        public IActionResult RemovePost(int id)
        {
            dao.Remove(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditaPost(Post post)
        {
            if (ModelState.IsValid)
            {
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
            Post post = dao.FindPost(id);
            return View("Visualiza", post);
        }

        public IActionResult PublicaPost(int id)
        {
            dao.Publica(id);
            return RedirectToAction("Index");
        }

        //implementar o autocomplete
        //public IActionResult AutoCompleteCategoria(string strTermo) 
        //{
            
        //}
    }
}