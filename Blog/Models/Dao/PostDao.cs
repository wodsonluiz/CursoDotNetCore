using Blog.Providers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blog.Models.Dao
{
    public class PostDao
    {
        public IList<Post> Lista()
        {
            try
            {
                List<Post> listaPost = new List<Post>();

                using (SqlConnection conexao = ConnectionFactory.GetConnection())
                {
                    SqlCommand cmd = conexao.CreateCommand();

                    cmd.CommandText = "SELECT * FROM POST";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Post p = new Post();

                        p.Id = Convert.ToInt32(reader["Id"]);
                        p.Titulo = Convert.ToString(reader["Titulo"]);
                        p.Resumo = Convert.ToString(reader["Resumo"]);
                        p.Categoria = Convert.ToString(reader["Categoria"]);

                        listaPost.Add(p);
                    };
                }

                return listaPost;
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
    }
}
