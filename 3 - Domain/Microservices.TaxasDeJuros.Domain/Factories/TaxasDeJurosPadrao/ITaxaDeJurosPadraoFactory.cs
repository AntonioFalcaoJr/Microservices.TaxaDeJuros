using CalculadoraDeJuros.Contratos.Domain;

namespace Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosPadrao
{
    public interface ITaxaDeJurosPadraoFactory<out T> : IFactory<T> where T : ITaxaDeJurosPadrao
    {
    }
}