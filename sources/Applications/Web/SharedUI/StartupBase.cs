
using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using TheSharpFactory.Apps.Shared.Services;
using TheSharpFactory.Apps.Shared.ViewModels.Conventional;

namespace TheSharpFactory.Apps.Web.SharedUI
{
    public abstract class StartupBase
    {
        public IConfiguration Configuration { get; internal set; }

        public static MvcApplicationModel AppModel { get; set; }

        protected StartupBase(IConfiguration configuration)
            => Configuration = configuration;

        public virtual void ConfigureServices(IServiceCollection services)
        {
            if (AppModel.CommunicationWay == MvcCommunicationWay.Direct)
            {
                //Database.RegisterModelConnectionString(
                //    RepoLookup.ModelId.WWI,
                //    Configuration.GetConnectionString("WWIConnectionString")
                //);
            }

            services.AddSingleton(_ => AppModel);
            services.AddTransient<IWeatherForecastDTO, WeatherForecastDTO>();
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            services.AddTransient<IFetchDataViewModel, FetchDataViewModel>();
            services.AddSingleton<ICounterService, CounterService>();

            services.AddControllersWithViews(opt => opt.EnableEndpointRouting = false);
        }

        public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env, MvcApplicationModel appModel)
        {
            var way = appModel.CommunicationWay;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            if (way == MvcCommunicationWay.ViaAPI)
            {
                // TODO: add a middleware to the request pipeline
                // which intercepts http calls to API backend
                // and adds the access token of the currently
                // logged-in user to HTTP request header 
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    "areas",
                    "Landing",
                    "{area:Exists}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}

