using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsApp.DataAccess;
using TeamsApp.DataAccess.Implementations;
using TeamsApp.DataAccess.Interfaces;
using TeamsApp.Domain.Models;
using TeamsApp.Services.Services.Implementations;
using TeamsApp.Services.Services.Interfaces;

namespace TeamsApp
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

            services.AddDbContext<TeamsAppDbContext>(x => x.UseSqlServer("Server=localhost;Database=TeamsApp;Trusted_Connection=True"));
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<IService<Player>, PlayerService>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<IRepository<Player>, PlayerRepository>();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
