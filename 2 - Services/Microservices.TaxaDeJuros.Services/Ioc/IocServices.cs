using Microservices.TaxasDeJuros.Domain.Factories;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;
using Microservices.TaxasDeJuros.Services.TaxasDeJurosPadrao;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.TaxasDeJuros.Services.Ioc
{
    public class IocServices
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ITaxaDeJurosPadraoServices, TaxaDeJurosPadraoServices>();
            services.AddScoped<ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao>, TaxaDeJurosPadraoFactory>();
            services.AddScoped<ITaxaDeJurosPadrao, TaxaDeJurosPadrao>();
        }
    }
}