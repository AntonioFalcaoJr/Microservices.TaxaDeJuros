using CalculadoraDeJuros.Contratos.Domain;
using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosEspecial;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosPadrao;
using Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
{
    public class TaxaDeJurosChain : ITaxaDeJurosChain
    {
        private readonly TaxaDeJurosEspecialLink _taxaDeJurosEspecialLink;
        private readonly TaxaDeJurosPadraoLink _taxaDeJurosPadraoLink;

        public TaxaDeJurosChain(ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> taxaDeJurosPadraoFactory,
            ITaxaDeJurosEspecialFactory<ITaxaDeJurosEspecial> taxaDeJurosEspecialFactory)
        {
            _taxaDeJurosEspecialLink = new TaxaDeJurosEspecialLink(taxaDeJurosEspecialFactory);
            _taxaDeJurosPadraoLink = new TaxaDeJurosPadraoLink(taxaDeJurosPadraoFactory);

            _taxaDeJurosEspecialLink.SetProximoLink(_taxaDeJurosPadraoLink);
        }

        public TaxaDeJurosDto Get(TaxaDeJurosDto taxaDeJurosDto) => _taxaDeJurosEspecialLink.GetValor(taxaDeJurosDto);

        public decimal Get() => _taxaDeJurosPadraoLink.GetValor();
    }
}