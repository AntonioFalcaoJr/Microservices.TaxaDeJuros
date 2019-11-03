using CalculadoraDeJuros.Contratos.Domain;
using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosPadrao;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links
{
    internal class TaxaDeJurosPadraoLink : TaxaDeJurosLink
    {
        public TaxaDeJurosPadraoLink(ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> taxaDeJurosPadraoFactory)
            : base(taxaDeJurosPadraoFactory)
        {
        }

        protected override bool MatchType(TaxaDeJurosDto taxaDeJurosDto) => taxaDeJurosDto?.TaxaDeJuros is TaxaDeJurosPadrao;
    }
}