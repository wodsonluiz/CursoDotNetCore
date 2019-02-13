using Blog.Providers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Blog.Models.Dao
{
    public class PostDao
    {
        private BlogContext ctx;

        public PostDao(BlogContext _ctx)
        {
            this.ctx = _ctx;
        }

        public IList<Post> Lista()
        {
            try
            {
                return ctx.Post.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Adiciona(Post post)
        {
            using (SqlConnection conexao = ConnectionFactory.GetConnection())
            {
                SqlCommand cmd = conexao.CreateCommand();

                //cmd.CommandText = "Insert into Post(Titulo, Resumo, Categoria) Values('" +
                //    post.Titulo + "','" + post.Resumo + "','" + post.Categoria + "')";

                cmd.CommandText = "Insert into Post(Titulo, Resumo, Categoria) Values(@titulo, @resumo, @categoria)";
                cmd.Parameters.Add(new SqlParameter("Titulo", post.Titulo));
                cmd.Parameters.Add(new SqlParameter("Resumo", post.Resumo));
                cmd.Parameters.Add(new SqlParameter("Categoria", post.Categoria));

                cmd.ExecuteNonQuery();
            }
        }

        public IList<Post> BuscaCategoria(string categoria)
        {
            try
            {
                return ctx.Post.Where(x => x.Categoria.Contains(categoria)).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Remove(int id)
        {
            try
            {
                Post post = ctx.Post.Find(id);
                ctx.Post.Remove(post);
                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualiza(Post post)
        {
            ctx.Entry(post).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public Post FindPost(int id)
        {
            return ctx.Post.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Publica(int id)
        {
            Post post = ctx.Post.Find(id);
            post.Publicado = true;
            post.DataPublicacao = DateTime.Now;
            ctx.SaveChanges();
        }

        // implementar o autocomplete

        public List<Post> ListaPost()
        {
            return ctx.Post.Where(x => x.Publicado == true).OrderByDescending(p => p.DataPublicacao).ToList();
        }

        public List<Post> ListaPeloTermo(string termo)
        {
            if (string.IsNullOrEmpty(termo))
            {
                return ctx.Post.Where(x => x.Publicado == true).ToList();
            }
            else
            {
                return ctx.Post.Where(p => p.Publicado == true && (p.Titulo.Contains(termo) || p.Resumo.Contains(termo))).ToList();
            }
        }
    }
}
