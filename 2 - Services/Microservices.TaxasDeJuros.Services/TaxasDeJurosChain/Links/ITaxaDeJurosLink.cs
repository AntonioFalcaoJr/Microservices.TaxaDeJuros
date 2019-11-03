using CalculadoraDeJuros.Contratos.Dto;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosChain.Links
{
    internal interface ITaxaDeJurosLink
    {
        ITaxaDeJurosLink ProximoLink { get; set; }

        TaxaDeJurosDto GetValor(TaxaDeJurosDto taxaDeJurosDto);

        decimal GetValor();

        void SetProximoLink(ITaxaDeJurosLink taxaDeJurosLink);
    }
}