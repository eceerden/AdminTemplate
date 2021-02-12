using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default",
                       "/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}


//sb admin 2 // template indirilip layout page ayarlan�p giydirilecek
//3 tane listeleme ve detay yap�lacak ( https://northwind.now.sh/ orders, categories, suppliers )
//https://jsonplaceholder.typicode.com/ urlden postlar �ekilip tabloda g�sterilecek. 
//Tabloda yorumlara git ad�nda bir buton olacak. Butona t�klad���nda o postun yorumlar� ayr� bir sayfada tabloda listelenecek.
//Tablolar�n �st�nde data miktar�n� manuel olarak yaz.
//Soldaki men�lerden t�m uygulama �al��s�n ( linkleme yap�lacak )
