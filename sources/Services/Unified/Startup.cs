using System;
using System.IO;
using System.Reflection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

using TheSharpFactory.Common.Extensions.DependencyInjection.Mappers;
using TheSharpFactory.Domain.Extensions.DependencyInjection;
using TheSharpFactory.SDK.Clients;
using TheSharpFactory.Services.GraphTypes;
using TheSharpFactory.Services.Sales;

using GrpcService = TheSharpFactory.Services.Unified.Services.GrpcService;

namespace TheSharpFactory.Services.Unified
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
            => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddTransient<ISalesService, SalesService>();
            _ = services.AddGrpc();
            _ = services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
            }));
            _ = services.AddControllers();
            _ = services.AddMapper(true, true);
            _ = services.AddSharpFactoryDomain(() => Configuration.GetConnectionString("WWI"));
            _ = services.AddSwaggerGen(c
                =>
            {
                var apiEndpoint = Configuration.GetSection("Api").Get<ApiConfiguration>().Url;
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "The Sharp Factory API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = new Uri($"{apiEndpoint}/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Shayne Boyer",
                        Email = string.Empty,
                        Url = new Uri("https://twitter.com/spboyer"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri($"{apiEndpoint}/license"),
                    }
                }
                );
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            _ = services.AddSharpFactoryGraph();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c
                => c.SwaggerEndpoint("/swagger/v1/swagger.json", "The Sharp Factory REST API V1")
            );

            app.UseRouting();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                RequestPath = "/schemas/sales.proto"
            });

            app.UseAuthorization();

            app.UseGrpcWeb(new GrpcWebOptions { DefaultEnabled = true });
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GrpcService>().RequireCors("AllowAll");
                endpoints.MapAreaControllerRoute("areas", "sales", "{area:exists}/{Controller=Customers}");
                endpoints.MapControllers();
            });

            app.UseSharpFactoryGraph();
        }
    }
}
