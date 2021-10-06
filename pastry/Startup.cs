using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using pastry.Data;
using pastry.Data.interfaces;
using pastry.Data.mocks;
using pastry.Data.Models;
using pastry.Data.Repository;
//using Microsoft.Extensions.Hosting;

namespace pastry
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbSettings.json").Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));

            //services.AddTransient<IAllSweets, MocSweets>(); // объединить интерфейс и класс
            //services.AddTransient<ISweetsCategory, MockCategory>(); // объединить интерфейс и класс

            services.AddTransient<IAllSweets, SweetsRepository>(); // объединить интерфейс и класс
            services.AddTransient<ISweetsCategory, CategoryRepository>(); // объединить интерфейс и класс
            services.AddTransient<IAllOrders, OrdersRepository>(); // объединить интерфейс и класс


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));

            //services.AddMvc(); // model view controller 
            services.AddMvc(option => option.EnableEndpointRouting = false);


            services.AddMemoryCache();
            services.AddSession();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {  
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage(); // страница с ошибками

            app.UseStatusCodePages(); // коды страничек
            app.UseStaticFiles(); // использование статич файлов. отображение css файлов, картинок
            app.UseSession();
            //app.UseMvcWithDefaultRoute(); // отслеживать URL адрес


            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}"); // по умолчанию вызывается контроллер home и в ней функция index
                routes.MapRoute(name: "categoryFilter", template: "Sweets/{action}/{category?}", defaults: new { Controller = "Sweets", action = "List" });// category должно совпадать с названием в CarController (List (category))

            });


            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }


        }
    }
}
