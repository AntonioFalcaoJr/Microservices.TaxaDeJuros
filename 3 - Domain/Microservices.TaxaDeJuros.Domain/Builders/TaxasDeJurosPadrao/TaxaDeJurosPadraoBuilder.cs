using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;

namespace Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao
{
    public class TaxaDeJurosPadraoBuilder : ITaxaDeJurosPadraoBuilder<ITaxaDeJurosPadrao>
    {
        private decimal _valor;

        public ITaxaDeJurosPadrao Build() => new TaxaDeJurosPadrao(_valor);

        public ITaxaDeJurosBuilder<ITaxaDeJurosPadrao> WithValor(decimal valor)
        {
            _valor = valor;
            return this;
        }
    }
}