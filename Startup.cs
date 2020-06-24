using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PWABlog.Models.Blog.Autor;
using PWABlog.Models.Blog.Categoria;
using PWABlog.Models.Blog.Etiqueta;
using PWABlog.Models.Blog.Postagem;
using PWABlog.Models.Blog.Postagem.Revisao;
using PWABlog.Models.ControleDeAcesso;

namespace PWABlog
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

            // using(var databaseContext = new DatabaseContext())
            // {
            //    databaseContext.Database.EnsureCreated();
            //  }

            //Adicionar o serviço do mecanismo de controle de acesso

            //alterando para tentar realizar o commit

            services.AddIdentity<Usuario, Papel>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 6;

            }).AddEntityFrameworkStores<DatabaseContext>()
            .AddErrorDescriber<DescritorDeErros>();

            //Configurar o mecanismo de controle de acesso

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/acesso/login";
            });

            // Adicionar o serviço do controle de acesso
            services.AddTransient<ControleDeAcessoService>();

            // Adicionar o serviço do banco de dados
            services.AddDbContext<DatabaseContext>();

            // Adicionar os serviços de ORM das entidades do domínio
            services.AddTransient<CategoriaOrmService>();
            services.AddTransient<PostagemOrmService>();
            services.AddTransient<AutorOrmService>();
            services.AddTransient<EtiquetaOrmService>();
            services.AddTransient<RevisaoOrmService>();

            // Adicionar os serviços que possibilitam o funcionamento dos controllers e das views
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();


            //Configuração de Rotas
            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                /*  endpoints.MapControllerRoute(
                      name: "default",
                      pattern: "{controller=Home}/{action=Index}/{id?}");
              });*/

                //Rotas da  Área Comum

                endpoints.MapControllerRoute(
                    name: "comum",
                    pattern: "/",
                    defaults: new
                    {
                        controller = "Home",
                        action = "Index"
                    });

                //Rotas do Controle de Acesso
                endpoints.MapControllerRoute(
                    name: "controleDeAcesso",
                    pattern: "acesso/{action}",
                    defaults : new {controller = "ControleDeAcesso",action = "Login"}
                    );

                //Rotas da Área Administrativa

                endpoints.MapControllerRoute(
                    name: "admin.categorias",
                    pattern: "admin/categorias/{action}/{id?}",
                    defaults: new
                    {
                        controller = "AdminCategorias",
                        action = "Listar"
                    });

                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "admin",
                    defaults : new {controller = "Admin",action = "Painel"}
                    ) ;

                endpoints.MapControllerRoute(
                   name: "admin.etiquetas",
                   pattern: "admin/etiquetas/{action}/{id?}",
                   defaults: new
                   {
                       controller = "AdminEtiquetas",
                       action = "Listar"
                   });

                endpoints.MapControllerRoute(
                   name: "admin.postagem",
                   pattern: "admin/postagem/{action}/{id?}",
                   defaults: new
                   {
                       controller = "AdminPostagem",
                       action = "Listar"
                   });
                endpoints.MapControllerRoute(
                   name: "admin.revisao",
                   pattern: "admin/postagem/revisao/{action}/{id?}",
                   defaults: new
                   {
                       controller = "AdminRevisao",
                       action = "Listar"
                   });
            });
        }
    }
}