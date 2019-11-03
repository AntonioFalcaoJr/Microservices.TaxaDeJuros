using Microservices.TaxasDeJuros.Api.Controllers.Swagger;
using Microservices.TaxasDeJuros.Api.Controllers.v1;
using Microservices.TaxasDeJuros.Api.Controllers.v2;
using Microservices.TaxasDeJuros.Domain.Ioc;
using Microservices.TaxasDeJuros.Services.Ioc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Microservices.TaxasDeJuros.Api
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseSwagger();
            app.UseSwaggerUI(
                options =>
                {
                    foreach (var description in provider.ApiVersionDescriptions)
                    {
                        options.SwaggerEndpoint(
                            $"/swagger/{description.GroupName}/swagger.json",
                            description.GroupName.ToUpperInvariant());
                    }
                });

            app.UseMvc()
                .UseApiVersioning();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(m => { m.EnableEndpointRouting = false; })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddApiVersioning(s =>
            {
                s.DefaultApiVersion = new ApiVersion(1, 0);
                s.ReportApiVersions = true;
                s.AssumeDefaultVersionWhenUnspecified = true;

                s.Conventions.Controller<TaxaDeJurosV1Controller>().HasApiVersion(new ApiVersion(1, 0));
                s.Conventions.Controller<TaxaDeJurosV2Controller>().HasApiVersion(new ApiVersion(2, 0));
            });

            services.AddVersionedApiExplorer(options => options.GroupNameFormat = "'v'VVV");

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            services.AddSwaggerGen();

            IocServices.Register(services);
            IocDomain.Register(services);
        }
    }
}