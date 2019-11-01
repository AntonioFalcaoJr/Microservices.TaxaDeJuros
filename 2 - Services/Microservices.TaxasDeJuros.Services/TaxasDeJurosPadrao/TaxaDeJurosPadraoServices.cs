using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Domain.Factories;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosPadrao
{
    public class TaxaDeJurosPadraoServices : ITaxaDeJurosPadraoServices
    {
        private readonly ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> _taxaDeJurosPadraoFactory;

        public TaxaDeJurosPadraoServices(ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> taxaDeJurosPadraoFactory)
        {
            _taxaDeJurosPadraoFactory = taxaDeJurosPadraoFactory;
        }

        public Task<decimal> GetValorAsync(TaxaDeJurosDto taxaDeJurosDto, CancellationToken cancellationToken)
        {
            if (taxaDeJurosDto.TaxaDeJuros is null || taxaDeJurosDto.TaxaDeJuros is TaxaDeJurosPadrao)
                return GetValorDaTaxaDeJurosPadraoAsync(cancellationToken);
        }

        private Task<decimal> GetValorDaTaxaDeJurosPadraoAsync(CancellationToken cancellationToken) =>
            Task.Run(() =>
            {
                var taxaDeJuros = _taxaDeJurosPadraoFactory.Create();
                return taxaDeJuros?.Get() ?? 0;
            }, cancellationToken);
    }
}