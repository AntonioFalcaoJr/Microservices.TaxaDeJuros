using System.Threading;
using System.Threading.Tasks;

namespace Microservices.TaxasDeJuros.Services
{
    public interface ITaxaDeJurosServices
    {
        Task<decimal> GetValorAsync(CancellationToken cancellationToken);
    }
}