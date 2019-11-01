namespace Microservices.TaxasDeJuros.Domain.Builders
{
    public interface IBuilder<out T>
    {
        T Build();
    }
}