using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.MongoDbCore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using ShoppingWebApp.IdentityCore;
using ShoppingWebApp.Models;
using ShoppingWebApp.Services;
using Microsoft.AspNetCore.Identity.MongoDB;
using AspNetCore.Identity.MongoDbCore.Infrastructure;

namespace ShoppingWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);

            services.Configure<ShoppingDatabaseSettings>(
        Configuration.GetSection(nameof(ShoppingDatabaseSettings)));

            services.AddSingleton<IShoppingDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<ShoppingDatabaseSettings>>().Value);


            // services.AddIdentity<ApplicationUser, MongoIdentityRole>()
            //    .AddMongoDbStores<IdentityMongoDbContext>(new IdentityMongoDbContext()).AddDefaultTokenProviders();

            var mongoSettings = Configuration.GetSection(nameof(MongoDbSettings));
            var settings = Configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();

            services.AddSingleton<MongoDbSettings>(settings);

            services.AddIdentity<ApplicationUser, MongoIdentityRole>()
                    .AddMongoDbStores<ApplicationUser, MongoIdentityRole, Guid>(settings.ConnectionString, settings.DatabaseName)
                    .AddSignInManager()
                    .AddDefaultTokenProviders();


            services.AddSingleton(typeof(IGenericService<>),typeof(GenericService<>));
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
            services.AddControllers();

            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseSession();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
           // SeedIdentity.CreateIdentityUsers(app.ApplicationServices, Configuration).Wait();

        }
    }
}
