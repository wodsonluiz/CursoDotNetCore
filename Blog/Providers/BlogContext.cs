using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Blog.Providers
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //        .AddEnvironmentVariables();

        //    IConfiguration configuration = builder.Build();
        //    string stringConexao = configuration.GetConnectionString("Blog");
        //    options.UseSqlServer(stringConexao);
        //}
    }
}
