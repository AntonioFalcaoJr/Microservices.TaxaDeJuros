using CalculadoraDeJuros.Contratos.Dto;
using System;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
{
    public interface ITaxaDeJurosChain
    {
        TaxaDeJurosDto Get(Guid id);

        decimal Get();
    }
}