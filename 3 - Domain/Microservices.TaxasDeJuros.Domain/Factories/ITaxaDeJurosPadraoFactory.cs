using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;

namespace Microservices.TaxasDeJuros.Domain.Factories
{
    public interface ITaxaDeJurosPadraoFactory<out T> : IFactory<T> where T : ITaxaDeJurosPadrao
    {
    }
}