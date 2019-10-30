using Microservices.TaxasDeJuros.Services.TaxasDeJurosPadrao;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.TaxasDeJuros.Services.Ioc
{
    public class IocServices
    {
        public class IoCServices
        {
            public static void Register(IServiceCollection services)
            {
                services.AddScoped<ITaxaDeJurosPadraoServices, TaxaDeJurosPadraoServices>();
            }
        }
    }
}