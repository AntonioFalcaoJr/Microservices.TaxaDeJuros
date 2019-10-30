namespace Microservices.TaxasDeJuros.Domain.Factories
{
    public interface IFactory<out T>
    {
        T Create();
    }
}