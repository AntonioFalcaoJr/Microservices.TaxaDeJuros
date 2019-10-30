namespace Microservices.TaxasDeJuros.Domain.Builders
{
    public interface ITaxaDeJurosBuilder<out T> : IBuilder<T>
    {
        ITaxaDeJurosBuilder<T> WithValor(double valor);
    }
}