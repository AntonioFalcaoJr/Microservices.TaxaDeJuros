using CalculadoraDeJuros.Contratos.Dto;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain
{
    internal interface ITaxaDeJurosLink
    {
        ITaxaDeJurosLink ProximoLink { get; set; }

        decimal GetValor(TaxaDeJurosDto taxaDeJurosDto);

        void SetProximoLink(ITaxaDeJurosLink taxaDeJurosLink);
    }
}