using CalculadoraDeJuros.Contratos.Domain;
using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain.Factories;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
{
    internal abstract class TaxaDeJurosLink : ITaxaDeJurosLink
    {
        protected TaxaDeJurosLink(IFactory<ITaxaDeJuros> factory)
        {
            Factory = factory;
        }

        public ITaxaDeJurosLink ProximoLink { get; set; }
        protected IFactory<ITaxaDeJuros> Factory { get; set; }

        public abstract decimal GetValor(TaxaDeJurosDto taxaDeJurosDto);

        public void SetProximoLink(ITaxaDeJurosLink taxaDeJurosLink) => ProximoLink = taxaDeJurosLink;
    }
}