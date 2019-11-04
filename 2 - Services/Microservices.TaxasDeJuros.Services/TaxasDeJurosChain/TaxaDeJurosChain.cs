using CalculadoraDeJuros.Contratos.Domain;
using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Data;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosEspecial;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosPadrao;
using Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links;
using System;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
{
    public class TaxaDeJurosChain : ITaxaDeJurosChain
    {
        private readonly TaxaDeJurosEspecialLink _taxaDeJurosEspecialLink;
        private readonly TaxaDeJurosPadraoLink _taxaDeJurosPadraoLink;

        public TaxaDeJurosChain(ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> taxaDeJurosPadraoFactory,
            ITaxaDeJurosEspecialFactory<ITaxaDeJurosEspecial> taxaDeJurosEspecialFactory, ITaxasDeJurosContext taxasDeJurosContext)
        {
            _taxaDeJurosEspecialLink = new TaxaDeJurosEspecialLink(taxaDeJurosEspecialFactory, taxasDeJurosContext);
            _taxaDeJurosPadraoLink = new TaxaDeJurosPadraoLink(taxaDeJurosPadraoFactory, taxasDeJurosContext);

            _taxaDeJurosEspecialLink.SetProximoLink(_taxaDeJurosPadraoLink);
        }

        public TaxaDeJurosDto Get(Guid id) => _taxaDeJurosEspecialLink.GetValor(id);

        public decimal Get() => _taxaDeJurosPadraoLink.GetValor();
    }
}