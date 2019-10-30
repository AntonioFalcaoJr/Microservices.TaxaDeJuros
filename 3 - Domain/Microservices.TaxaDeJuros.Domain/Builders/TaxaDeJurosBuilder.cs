using Microservices.TaxaDeJuros.Domain.Taxas;

namespace Microservices.TaxaDeJuros.Domain.Builders
{
    public class TaxaDeJurosBuilder : ITaxaDeJurosBuilder
    {
        private double _valor;

        public Taxa Build() => new Taxa(_valor);

        public ITaxaDeJurosBuilder WithValor(double valor)
        {
            _valor = valor;
            return this;
        }
    }
}
