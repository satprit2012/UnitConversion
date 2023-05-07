using System;
using UnitConversion.Service;
using static System.Net.Mime.MediaTypeNames;

namespace UnitConversion
{
    public class Startup
    {
        public IConfiguration Configuration { get;  }

        public Startup(IConfiguration config)
        { Configuration = config; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUnitConversionService, UnitConversionService>();
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();
        }
    }
}
