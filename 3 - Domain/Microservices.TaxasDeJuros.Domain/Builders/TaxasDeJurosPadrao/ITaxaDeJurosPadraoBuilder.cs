using CalculadoraDeJuros.Contratos.Domain;

namespace Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao
{
    public interface ITaxaDeJurosPadraoBuilder<out T> : ITaxaDeJurosBuilder<T> where T : ITaxaDeJurosPadrao
    {
    }
}