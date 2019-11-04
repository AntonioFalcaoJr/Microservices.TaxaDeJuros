using CalculadoraDeJuros.Contratos.Domain;
using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain.Factories;
using System;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links
{
    public abstract class TaxaDeJurosLink : ITaxaDeJurosLink
    {
        protected readonly IFactory<ITaxaDeJuros> Factory;

        protected TaxaDeJurosLink(IFactory<ITaxaDeJuros> factory)
        {
            Factory = factory;
        }

        public ITaxaDeJurosLink ProximoLink { get; set; }

        public abstract TaxaDeJurosDto GetValor(Guid id);

        public decimal GetValor() => Factory.Create().Get();

        public void SetProximoLink(ITaxaDeJurosLink taxaDeJurosLink) => ProximoLink = taxaDeJurosLink;
    }
}