using Microservices.TaxasDeJuros.Domain.TaxasDeJurosEspecial;

namespace Microservices.TaxasDeJuros.Domain.Factories
{
    public interface ITaxaDeJurosEspecialFactory<out T> : IFactory<T> where T : ITaxaDeJurosEspecial
    {
    }
}