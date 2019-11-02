using CalculadoraDeJuros.Contratos.Dto;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
{
    public interface ITaxaDeJurosChain
    {
        decimal Get(TaxaDeJurosDto taxaDeJurosDto);
    }
}