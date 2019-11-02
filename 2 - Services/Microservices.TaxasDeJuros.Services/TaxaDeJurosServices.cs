using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Services.TaxasDeJurosChain;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.TaxasDeJuros.Services
{
    public class TaxaDeJurosServices : ITaxaDeJurosServices
    {
        private readonly ITaxaDeJurosChain _taxaDeJurosChain;

        public TaxaDeJurosServices(ITaxaDeJurosChain taxaDeJurosChain)
        {
            _taxaDeJurosChain = taxaDeJurosChain;
        }

        public Task<decimal> GetValorAsync(TaxaDeJurosDto taxaDeJurosDto, CancellationToken cancellationToken) =>
            Task.Run(() => _taxaDeJurosChain.Get(taxaDeJurosDto), cancellationToken);
    }
}