using Blog.Models;
using Blog.Models.Dao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Areas.Api.Controllers
{
    [Area("Api")]
    [ApiController]
    [Route("/api/post")]
    public class PostApiController : ControllerBase
    {
        private readonly PostDao dao;

        public PostApiController(PostDao _dao)
        {
            dao = _dao;
        }

        [HttpGet]
        [Route("BuscaTodosPosts")]
        public IActionResult BuscaTodosPosts()
        {
            IList<Post> posts = dao.Lista();
            return Ok(posts);
        }

        [HttpGet]
        [Route("BuscaPostId")]
        public IActionResult BuscaPostId(int id)
        {
            return Ok(dao.FindPost(id));
        }

        [HttpPost]
        [Route("Novo")]
        public IActionResult CadastraPost([FromBody] Post post)
        {
            if (ModelState.IsValid)
            {
                dao.Adiciona(post);
                return CreatedAtAction("BuscaPostId", new { id = post.Id }, post);
            }

            return BadRequest(ModelState);
        }

        [HttpPut]
        [Route("Altera")]
        public IActionResult AtualizaPost(int id, [FromBody] Post post)
        {
            Post postBanco = dao.FindPost(id);

            if (postBanco == null)
            {
                return NotFound();
            }

            postBanco.Titulo = post.Titulo;
            postBanco.Resumo = post.Resumo;
            postBanco.Categoria = post.Categoria;
            postBanco.Publicado = post.Publicado;
            postBanco.DataPublicacao = post.DataPublicacao;

            dao.Atualiza(postBanco);
            return NoContent();
        }

        [HttpDelete]
        [Route("Deletar")]
        public IActionResult DeletePost(int id)
        {
            if (dao.FindPost(id) == null)
            {
                return NotFound();
            }
            dao.Remove(id);
            return NoContent();
        }
    }
}