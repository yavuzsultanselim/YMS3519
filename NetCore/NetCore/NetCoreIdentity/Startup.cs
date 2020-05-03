using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreIdentity.Models.Context;
using NetCoreIdentity.Models.Entity;

namespace NetCoreIdentity
{
    public class Startup
    {

        //SqlServer kullanabilmek i�in a�a��daki k�t�phaneyi Nuget paket y�neticisini kullanarak projeye dahil etmeniz gerekmektedir.
        /*
         install-package Microsoft.EntityFrameworkCore.SqlServer

            ayr�ca komut istemcisi ile veritaban� migration i�lemini ger�ekle�tirebilmek i�in a�a��daki iki k�t�thaneye ihtiyac�n�z bulunmaktad�r;
            Microsoft.EntityFrameworkCore.Design
            Microsoft.EntityFrameworkCore.Tools

            ard�ndan package manager console a��larak ilk olarak;
            add-migration
            komutu yaz�l�p ard�ndan migration'a bir isim vermemizi bekleyecek.
            veritaban�n� olu�turmak i�in;
            update-database komutunu kullanabilirsiniz.
             */
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer("server=.;database=NetCoreIdentityDB;uid=sa;pwd=123"));

            services.AddIdentity<AppUser, AppUserRole>().AddEntityFrameworkStores<AppDbContext>();

            //cookie olu�turma
            services.ConfigureApplicationCookie(x =>
            {
                x.LoginPath = new PathString("/Account/Login");

                x.Cookie = new CookieBuilder
                {
                    Name = "LoginCookie",
                    HttpOnly = false,
                    Expiration = null
                };
                x.SlidingExpiration = true;
                x.ExpireTimeSpan = TimeSpan.FromMinutes(1);
            });
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
            name: "areas",
            template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}

//Home/Index