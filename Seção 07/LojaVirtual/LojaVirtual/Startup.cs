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

namespace LojaVirtual
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
            services.AddControllersWithViews();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
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
            app.UseDefaultFiles(); //Usar o index.html com default, o Startup.cs tem a preferencia e não o controlador
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            /*
             * Quando digito o endereço de um site ex: www.site.com.br
             * o memo precisa saber para qual controlador (Gestor das requisições) ele vai
             * e que define isso são as rotas
             * 
             * www.site.com.br/Produto/Visualizar/MouseRazorZK    ---> ORDEM : SITE/CLASSE(CONTROLLER)/METODO/ID NO BANCO DE DADOS
             * OU
             * www.site.com.br/Produto/Visualizar/10
             * www.site.com.br/Produto/Visualizar/   -----> O ultimo parametro é opcional, pois posso querer mostrar uma pagina com todos os produtos e não só 1
             * 
             * 
             * www.site.com.br/{caminho}?{querystring}#{fragmento}
             * 
             */

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
