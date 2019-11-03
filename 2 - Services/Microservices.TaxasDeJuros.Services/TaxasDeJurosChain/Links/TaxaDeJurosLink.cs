using CalculadoraDeJuros.Contratos.Domain;
using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain.Factories;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links
{
    internal abstract class TaxaDeJurosLink : ITaxaDeJurosLink
    {
        protected TaxaDeJurosLink(IFactory<ITaxaDeJuros> factory)
        {
            Factory = factory;
        }

        public ITaxaDeJurosLink ProximoLink { get; set; }
        private IFactory<ITaxaDeJuros> Factory { get; }

        public TaxaDeJurosDto GetValor(TaxaDeJurosDto taxaDeJurosDto)
        {
            var dto = new TaxaDeJurosDto();

            if (MatchType(taxaDeJurosDto))
            {
                dto.Valor = Factory.Create().Get();
                return dto;
            }

            if (ProximoLink is null)
            {
                dto.AddError("O tipo de Taxa de Juros deve ser informado.");
                return dto;
            }

            return ProximoLink.GetValor(taxaDeJurosDto);
        }

        public decimal GetValor() => Factory.Create().Get();

        public void SetProximoLink(ITaxaDeJurosLink taxaDeJurosLink) => ProximoLink = taxaDeJurosLink;

        protected abstract bool MatchType(TaxaDeJurosDto taxaDeJurosDto);
    }
}