using CalculadoraDeJuros.Contratos.Dto;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
{
    public interface ITaxaDeJurosChain
    {
        TaxaDeJurosDto Get(TaxaDeJurosDto taxaDeJurosDto);

        decimal Get();
    }
}