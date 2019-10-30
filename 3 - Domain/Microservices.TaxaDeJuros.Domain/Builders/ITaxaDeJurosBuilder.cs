using Microservices.TaxaDeJuros.Domain.Taxas;

namespace Microservices.TaxaDeJuros.Domain.Builders
{
    public interface ITaxaDeJurosBuilder
    {
        Taxa Build();
        ITaxaDeJurosBuilder WithValor(double valor);
    }
}
