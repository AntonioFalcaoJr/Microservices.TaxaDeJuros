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

        public override decimal GetValor(TaxaDeJurosDto taxaDeJurosDto)
        {
            return taxaDeJurosDto?.TaxaDeJuros is TaxaDeJurosPadrao
                ? Factory.Create().Get()
                : ProximoLink.GetValor(taxaDeJurosDto);
        }
    }
}