using CalculadoraDeJuros.Contratos.Domain;

namespace Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosEspecial
{
    public interface ITaxaDeJurosEspecialBuilder<out T> : ITaxaDeJurosBuilder<T> where T : ITaxaDeJurosEspecial
    {
    }
}