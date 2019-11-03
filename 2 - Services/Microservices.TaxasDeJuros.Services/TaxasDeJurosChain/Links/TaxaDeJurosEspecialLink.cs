using CalculadoraDeJuros.Contratos.Domain;
using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosEspecial;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links
{
    internal class TaxaDeJurosEspecialLink : TaxaDeJurosLink
    {
        public TaxaDeJurosEspecialLink(ITaxaDeJurosEspecialFactory<ITaxaDeJurosEspecial> taxaDeJurosEspecialFactory)
            : base(taxaDeJurosEspecialFactory)
        {
        }

        protected override bool MatchType(TaxaDeJurosDto taxaDeJurosDto) => taxaDeJurosDto?.TaxaDeJuros is TaxaDeJurosEspecial;
    }
}