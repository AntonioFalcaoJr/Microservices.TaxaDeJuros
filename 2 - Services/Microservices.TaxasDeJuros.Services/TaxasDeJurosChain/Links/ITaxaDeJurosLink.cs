using CalculadoraDeJuros.Contratos.Dto;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links
{
    internal interface ITaxaDeJurosLink
    {
        ITaxaDeJurosLink ProximoLink { get; set; }

        decimal GetValor(TaxaDeJurosDto taxaDeJurosDto);

        void SetProximoLink(ITaxaDeJurosLink taxaDeJurosLink);
    }
}