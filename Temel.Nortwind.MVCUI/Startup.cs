using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Temel.Nortwind.Business.Abstract;
using Temel.Nortwind.Business.Concrete;
using Temel.Nortwind.DAL.Abstract;
using Temel.Nortwind.DAL.Concrete.EntityFreamwork;
using Temel.Nortwind.MVCUI.Middleware;
using Temel.Nortwind.MVCUI.Services;

namespace Temel.Nortwind.MVCUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<IProductDAL,EfProductDAL>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDAL, EfCategoryDAL>();
            services.AddSingleton<ICartServiceSession, CartSessionService>();
            services.AddSingleton<ICartService, CartService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddSession();

            services.AddDistributedMemoryCache();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // middleware ,hata yönetimi için
            }
            app.UseStaticFiles();//static file yönetimi için 
            app.useNodeModules(env.ContentRootPath);
            app.UseSession();
            app.UseMvcWithDefaultRoute();  //mvc routing için
        }
    }
}
