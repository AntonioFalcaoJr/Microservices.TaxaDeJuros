using CalculadoraDeJuros.Contratos.Domain;

namespace Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosEspecial
{
    public interface ITaxaDeJurosEspecialFactory<out T> : IFactory<T> where T : ITaxaDeJurosEspecial
    {
    }
}