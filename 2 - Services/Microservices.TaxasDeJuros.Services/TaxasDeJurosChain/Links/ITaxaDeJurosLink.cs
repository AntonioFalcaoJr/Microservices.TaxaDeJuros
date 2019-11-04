using CalculadoraDeJuros.Contratos.Dto;
using System;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links
{
    public interface ITaxaDeJurosLink
    {
        ITaxaDeJurosLink ProximoLink { get; set; }

        TaxaDeJurosDto GetValor(Guid id);

        decimal GetValor();

        void SetProximoLink(ITaxaDeJurosLink taxaDeJurosLink);
    }
}