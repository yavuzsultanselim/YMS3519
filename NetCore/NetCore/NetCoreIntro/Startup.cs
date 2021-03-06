using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NetCoreIntro
{
    public class Startup
    {
      //Projeyi ilk oluşturduğumuzda bu proje bir mvc projesi olarak oluşturulmamaktadır. Doğrudan core projesidir. Bizler burdaki sevis içerisinde MVC projesi olduğunu gösteren servisi çağırdığımızda bu proje artık bir mvc projesi olarak çalışacaktır. Bu yüzden ConfigureServices metodu içerisinde services.AddMvc() isimli metodu tanımladık.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x=>x.EnableEndpointRouting=false);
        }

      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //wwwroot klasörünü kullanabilmek için aşağıdaki metodu tanımlamalısnız.
            app.UseStaticFiles();

            app.UseRouting();
            //custom route tanımlamak isterseniz aşağıdaki metodu kullanabilirsiniz.
            app.UseMvc(rotues =>
            {

                rotues.MapRoute(
                    name: "ProductRotue",
                    template: "SelectedProduct/{ProductName}/{productId}",
                    defaults: new { controller = "Product", action = "GetProduct" }
                    );

                rotues.MapRoute(
                   name: "ProductCategory",
                   template: "SelectedProductCategory/{CategoryName}/{categoryId}",
                   defaults: new { controller = "Product", action = "GetProductsWithCategory" }
                   );

                rotues.MapRoute(
                    name: "Default",
                    template: "{Controller=Home}/{Action=Index}/{id?}"
                    );
            });

            //Default route tanımlamak isterseniz aşağıdaki metodu kullanabilirsiniz.
            //app.UseMvcWithDefaultRoute();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Merhaba Dünya!");
                });
            });
        }
    }
}
