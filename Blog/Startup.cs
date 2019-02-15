using Blog.Models.Dao;
using Blog.Providers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
                services.Configure<CookiePolicyOptions>(options =>
                {
                    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                    options.CheckConsentNeeded = context => false;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                });


                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

                //Cria nossa Context pegando nossa connectionString
                services.AddDbContext<BlogContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Blog")));

                //Cria nossa Dao ja implementando o context
                services.AddTransient<PostDao>();
                services.AddTransient<UsuarioDao>();

                services.AddSession();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();// adiciona session na aplicação

            app.UseMvc(routes =>
            {

                routes.MapRoute(
                  name: "areasApi",
                  template: "{area:exists}/{controller=PostApi}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                 name: "areaRoute",
                 template: "{area:exists}/{controller=Post}/{action=Index}/{id?}"
               );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");


            });

        }
    }
}
