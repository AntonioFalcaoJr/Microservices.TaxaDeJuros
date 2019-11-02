using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain.Factories;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosEspecial;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
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