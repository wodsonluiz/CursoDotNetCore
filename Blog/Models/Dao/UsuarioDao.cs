using Blog.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Dao
{
    public class UsuarioDao
    {
        private BlogContext ctx;
        public UsuarioDao(BlogContext _ctx)
        {
            ctx = _ctx;
        }

        public Usuario Busca(string login, string senha)
        {
            return ctx.Usuarios.Where(usuario => usuario.Nome.Equals(login) && usuario.Senha.Equals(senha)).
                FirstOrDefault<Usuario>();
        }

        public void Adicona(Usuario usuario)
        {
            ctx.Usuarios.Add(usuario);
            ctx.SaveChanges();
        }
    }
}
