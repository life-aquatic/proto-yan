using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using proto.Data;
using Microsoft.EntityFrameworkCore;
using proto.DIscratch;
using proto.ConfigurationExample;

namespace proto
{
    public class Startup
    {
        

        public Startup(IHostingEnvironment env)
        {
            //adding json's here and in program.cs. why? I guess the book is about asp net 2.0 and I'm using 3.0
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json",
                     optional: false,
                     reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();
            //Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container. "Configuration" object is available here
        // I can do whatever I please with it.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CDPContext>(options =>
                options.UseSqlServer(Configuration["Database:ConnectionString"]));
            //services.AddDatabaseDeveloperPageExceptionFilter(); I don't know why I need this. this adds some error information somewhere
            
            //page 332 explains this. this function binds configuration objects to strongly typed POCO's
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.Configure<ConfigurableContent>(Configuration.GetSection("ConfigurableContent"));//my half-baked configuration object
            services.AddTransient < Repository >();
            services.AddTransient<DataContext>();
            services.ConfigureByExtension();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMvc().AddXmlSerializerFormatters();
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "testbind",
                    template: "{controller=Home}/{action}/{value?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
          
        }
    }
}
