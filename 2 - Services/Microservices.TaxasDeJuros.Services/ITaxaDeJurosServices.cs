using CalculadoraDeJuros.Contratos.Dto;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.TaxasDeJuros.Services
{
    public interface ITaxaDeJurosServices
    {
        Task<decimal> GetValorAsync(TaxaDeJurosDto taxaDeJurosDto, CancellationToken cancellationToken);
    }
}