using Microservices.TaxasDeJuros.Data.Seed;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.TaxasDeJuros.Data.Ioc
{
    public class IocData
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ITaxasDeJurosContext, TaxasDeJurosContext>();
            services.AddScoped<IEntitySeed, TaxaDeJurosSeed>();
        }
    }
}