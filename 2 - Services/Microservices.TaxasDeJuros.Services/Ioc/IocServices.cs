using Microservices.TaxasDeJuros.Services.TaxasDeJurosChain;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.TaxasDeJuros.Services.Ioc
{
    public static class IocServices
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ITaxaDeJurosServices, TaxaDeJurosServices>();
            services.AddScoped<ITaxaDeJurosChain, TaxaDeJurosChain>();
        }
    }
}