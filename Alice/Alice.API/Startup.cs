using Alice.Business.Abstract;
using Alice.Business.Concrete;
using Alice.DataAccess;
using Alice.DataAccess.Abstract;
using Alice.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice.API
{
    public class Startup
    {
        IConfiguration configuration;
        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<MSSQLDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("CS1")));
            services.AddSingleton<IOgrenciService, OgrenciMenager>();
            services.AddSingleton<IOgrenciRepository, OgrenciRepository>();
            services.AddSwaggerDocument();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            else app.UseStatusCodePagesWithReExecute("/hata/{0}");

            app.UseStaticFiles();
            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
