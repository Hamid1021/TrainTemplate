using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Xml.Linq;

namespace TrainWeb
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseCustomLogger();

            //// Map
            //app.Map("/item", ApplicationBuilder =>
            //{
            //    ApplicationBuilder.Use(async (context, next) =>
            //    {
            //        context.Items.Add("product", "P1");
            //        await next.Invoke();
            //    });
            //    ApplicationBuilder.Run(async context =>
            //    {
            //        var productName = context.Items["product"];
            //        await context.Response.WriteAsync($"The Product Name is {productName}\n");
            //        await context.Response.WriteAsync("I using a Map Horry ...!");
            //    });
            //});


            //// Use
            //app.Use(async (context, next) =>
            //{
            //    context.Items.Add("name", "Hamidreza");

            //    await next.Invoke();
            //});

            //app.Use(async (context, next) =>
            //{
            //    var Id = context.Request.Query["id"];
            //    await context.Response.WriteAsync($"The ID is {Id}\n");
            //    await next.Invoke();
            //});

            //// Run
            //app.Run(async context =>
            //{
            //    var name = context.Items["name"];
            //    await context.Response.WriteAsync($"Application Excuted SuccessFully {name}");
            //});
            #region Defailt MiddelWare

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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            #endregion
        }
    }
}
