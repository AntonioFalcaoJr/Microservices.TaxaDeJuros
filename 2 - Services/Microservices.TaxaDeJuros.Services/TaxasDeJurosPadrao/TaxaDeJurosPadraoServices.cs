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

        public Task<decimal> GetValorAsync(CancellationToken cancellationToken) =>
            Task.Run(() =>
            {
                var taxaDeJuros = _taxaDeJurosPadraoFactory.Create();
                return taxaDeJuros?.Get() ?? 0;
            }, cancellationToken);
    }
}