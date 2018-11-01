/**
 * Author: Dmitry Gkrigorev
 * Created At: 22.10.2018
 * Descirption: Scheme editor for Scada (RapidScada)
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ScadaSchemeEditor
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            // Enable using static files
            app.UseStaticFiles();
            // Enable cookie policy
            app.UseCookiePolicy();
            // Routing
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default", 
                    template: "{controller=Scheme}/{action=Index}");
                routes.MapRoute(
                    name: "service/update",
                    template: "{controller=Scheme}/{action=Update");
                routes.MapRoute(
                    name: "service/load",
                    template: "{controller=Scheme}/{action=Load");
            });
        }
    }
}
