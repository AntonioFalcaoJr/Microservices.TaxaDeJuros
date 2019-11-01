using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao;
using Microservices.TaxasDeJuros.Domain.Factories;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.TaxasDeJuros.Domain.Ioc
{
    public class IocDomain
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ITaxaDeJurosPadrao, TaxaDeJurosPadrao>();
            services.AddScoped<ITaxaDeJurosPadraoBuilder<ITaxaDeJurosPadrao>, TaxaDeJurosPadraoBuilder>();
            services.AddScoped<ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao>, TaxaDeJurosPadraoFactory>();
        }
    }
}