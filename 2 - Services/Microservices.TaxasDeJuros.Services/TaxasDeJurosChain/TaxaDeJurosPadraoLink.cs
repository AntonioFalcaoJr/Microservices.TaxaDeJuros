using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain.Factories;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;
using System;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
{
    internal class TaxaDeJurosPadraoLink : TaxaDeJurosLink
    {
        public TaxaDeJurosPadraoLink(ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> taxaDeJurosPadraoFactory)
            : base(taxaDeJurosPadraoFactory)
        {
        }

        public override decimal GetValor(TaxaDeJurosDto taxaDeJurosDto)
        {
            return taxaDeJurosDto?.TaxaDeJuros is TaxaDeJurosPadrao
                ? Factory.Create().Get()
                : ProximoLink?.GetValor(taxaDeJurosDto) ??
                  throw new Exception("O Tipo de Taxa de Juros deve ser informada.");
        }
    }
}