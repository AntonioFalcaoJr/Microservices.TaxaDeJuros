using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.TaxasDeJuros.Domain.Ioc
{
    public class IocDomain
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ITaxaDeJurosPadraoBuilder<ITaxaDeJuros>, TaxaDeJurosPadraoBuilder>();
        }
    }
}