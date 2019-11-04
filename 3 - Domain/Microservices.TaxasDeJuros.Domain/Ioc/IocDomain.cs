using CalculadoraDeJuros.Contratos.Domain;
using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosEspecial;
using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosEspecial;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosPadrao;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.TaxasDeJuros.Domain.Ioc
{
    public static class IocDomain
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ITaxaDeJurosPadrao, TaxaDeJurosPadrao>();
            services.AddScoped<ITaxaDeJurosEspecial, TaxaDeJurosEspecial>();

            services.AddScoped<ITaxaDeJurosPadraoBuilder<ITaxaDeJurosPadrao>, TaxaDeJurosPadraoBuilder>();
            services.AddScoped<ITaxaDeJurosEspecialBuilder<ITaxaDeJurosEspecial>, TaxaDeJurosEspecialBuilder>();

            services.AddScoped<ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao>, TaxaDeJurosPadraoFactory>();
            services.AddScoped<ITaxaDeJurosEspecialFactory<ITaxaDeJurosEspecial>, TaxaDeJurosEspecialFactory>();
        }
    }
}