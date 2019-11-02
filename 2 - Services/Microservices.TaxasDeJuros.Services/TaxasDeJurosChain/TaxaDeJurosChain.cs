using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain.Factories;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosEspecial;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
{
    public class TaxaDeJurosChain : ITaxaDeJurosChain
    {
        private readonly TaxaDeJurosEspecialLink _taxaDeJurosEspecialLink;

        public TaxaDeJurosChain(ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> taxaDeJurosPadraoFactory,
            ITaxaDeJurosEspecialFactory<ITaxaDeJurosEspecial> taxaDeJurosEspecialFactory)
        {
            _taxaDeJurosEspecialLink = new TaxaDeJurosEspecialLink(taxaDeJurosEspecialFactory);
            var taxaDeJurosPadraoLink = new TaxaDeJurosPadraoLink(taxaDeJurosPadraoFactory);

            _taxaDeJurosEspecialLink.SetProximoLink(taxaDeJurosPadraoLink);
        }

        public decimal Get(TaxaDeJurosDto taxaDeJurosDto) => _taxaDeJurosEspecialLink.GetValor(taxaDeJurosDto);
    }
}