using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Apps.Shared.Services;
using TheSharpFactory.Apps.Shared.ViewModels.Conventional;

#if netcoreapp31
using ElectronNET.API;
using ElectronNET.API.Entities;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using WebWindows.Blazor;
#endif

namespace TheSharpFactory.Apps.Web.SharedUI
{
    public class StartupBase
    {
        public IConfiguration Configuration { get; internal set; }

        public static BlazorApplicationModel AppModel { get; set; }

        public StartupBase()
        {
        }

        public StartupBase(IConfiguration configuration)
            => Configuration = configuration;

#if netcoreapp31
        private void AddServerSideBlazor(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor(c =>
            {
                c.DetailedErrors = true;
                c.JSInteropDefaultCallTimeout = new System.TimeSpan(10000);
            });
        }
#endif

        public void ConfigureServices(IServiceCollection services)
        {
            using (var sp = services.BuildServiceProvider())
            {
                if (Configuration is null)
                {
                    try
                    {
                        Configuration = sp.GetRequiredService<IConfiguration>();
                    }
                    catch { }
                }
            }

            var flavor = AppModel.Flavor;
            var platform = AppModel.Platform;

#if netcoreapp31
            if (flavor == BlazorFlavor.Server || flavor == BlazorFlavor.Hybrid || flavor == (BlazorFlavor.Server | BlazorFlavor.Hybrid))
            {
                if (platform == BlazorPlatform.Web || platform == BlazorPlatform.Electron || platform == (BlazorPlatform.Web | BlazorPlatform.Electron))
                    AddServerSideBlazor(services);
            }
#endif

            services.AddSingleton(_ => AppModel);
            services.AddTransient<IWeatherForecastDTO, WeatherForecastDTO>();
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            services.AddTransient<IFetchDataViewModel, FetchDataViewModel>();
            services.AddSingleton<ICounterService, CounterService>();
        }

#if netcoreapp31
        public void ConfigureBlazorServer(IApplicationBuilder app, IWebHostEnvironment env, BlazorApplicationModel appModel)
        {
            var flavor = appModel.Flavor;
            var platform = appModel.Platform;

            if (flavor == BlazorFlavor.Server || flavor == BlazorFlavor.Hybrid || flavor == (BlazorFlavor.Server | BlazorFlavor.Hybrid))
            {
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

                app.UseStaticFiles();
                app.UseRouting();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapBlazorHub();
                    endpoints.MapFallbackToPage("/_Host");
                });

                if (platform == BlazorPlatform.Web || platform == BlazorPlatform.Electron || platform == (BlazorPlatform.Web | BlazorPlatform.Electron))
                {
                    Task.Run(async ()
                        => await Electron.WindowManager.CreateWindowAsync(
                                new BrowserWindowOptions()
                                {
                                    Show = true,
                                    AutoHideMenuBar = true,

                                    WebPreferences = new WebPreferences()
                                    {
                                        AllowRunningInsecureContent = true,
                                        Sandbox = true
                                    }
                                }
                            )
                    )
                    ;
                }
            }
        }
        public void ConfigureWebWindow<TApplication>(DesktopApplicationBuilder app, string selector)
            where TApplication : ComponentBase
            => app.AddComponent<TApplication>(selector);
#endif
    }
}
