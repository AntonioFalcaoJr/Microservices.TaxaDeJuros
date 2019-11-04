using CalculadoraDeJuros.Contratos.Domain;
using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Data;
using Microservices.TaxasDeJuros.Domain;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosPadrao;
using System;
using System.Linq;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links
{
    public class TaxaDeJurosPadraoLink : TaxaDeJurosLink
    {
        private readonly ITaxasDeJurosContext _taxasDeJurosContext;

        public TaxaDeJurosPadraoLink(ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> taxaDeJurosPadraoFactory, ITaxasDeJurosContext taxasDeJurosContext)
            : base(taxaDeJurosPadraoFactory)
        {
            _taxasDeJurosContext = taxasDeJurosContext;
        }

        public override TaxaDeJurosDto GetValor(Guid id)
        {
            var dto = new TaxaDeJurosDto();

            if (_taxasDeJurosContext.TaxasDeJuros.Where(x => x is TaxaDeJurosPadrao).Any(x => x.Id == id))
            {
                dto.Valor = Factory.Create().Get();
                return dto;
            }

            if (ProximoLink is null)
            {
                dto.AddError("O tipo de Taxa de Juros deve ser informado.");
                return dto;
            }

            return ProximoLink.GetValor(id);
        }
    }
}