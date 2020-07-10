using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Apps.Shared.Services;
using TheSharpFactory.Apps.Shared.ViewModels.Conventional;

using System.Diagnostics.CodeAnalysis;

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
        #region .NET Standard 2.0
#if netstandard20
        #region Protected Members
        #region Constructors
        protected StartupBase(IConfiguration configuration)
            => Configuration = configuration;
        #endregion
        #endregion

        #region Public Members
        #region Properties
        public IConfiguration Configuration { get; internal set; }
        public BlazorApplicationModel AppModel { get; protected set; }
        #endregion
        #endregion
#endif
        #endregion

        #region .NET Standard 2.1 Or ASP.NET Core 3.1
#if netstandard21
        protected StartupBase()
        {
        }
#endif
#if netcoreapp31
        #region Private members
        #region Methods
        private void AddServerSideBlazor(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor(c =>
            {
                c.DetailedErrors = true;
                c.JSInteropDefaultCallTimeout = new System.TimeSpan(10000);
            });
        }

        public void ConfigureBlazorServer(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            BlazorApplicationModel appModel
        )
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
        #endregion
        #endregion
#endif
#if netstandard21 || netcoreapp31
        #region Protected Members
        #region Constructors
        protected StartupBase(IConfiguration? configuration = null)
            => Configuration = configuration!;
        #endregion
        #endregion

        #region Public Members
        #region Properties
        public IConfiguration? Configuration { get; internal set; }
        public BlazorApplicationModel? AppModel { get; protected set; }
        #endregion

        #region Methods
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>")]
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

            var flavor = AppModel!.Flavor;
            var platform = AppModel!.Platform;
            var communicationWay = AppModel!.CommunicationWay;

#if netcoreapp31
            if (flavor == BlazorFlavor.Server || flavor == BlazorFlavor.Hybrid || flavor == (BlazorFlavor.Server | BlazorFlavor.Hybrid))
            {
                if (platform == BlazorPlatform.Web || platform == BlazorPlatform.Electron || platform == (BlazorPlatform.Web | BlazorPlatform.Electron))
                    AddServerSideBlazor(services);
            }
#endif

            services.AddSingleton(_ => AppModel!);
            services.AddTransient<IWeatherForecastDTO, WeatherForecastDTO>();
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            services.AddTransient<IFetchDataViewModel, FetchDataViewModel>();
            services.AddSingleton<ICounterService, CounterService>();
        }
        #endregion

        #endregion
#endif
        #endregion
    }
}
