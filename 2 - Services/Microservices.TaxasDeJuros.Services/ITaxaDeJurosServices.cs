using CalculadoraDeJuros.Contratos.Dto;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.TaxasDeJuros.Services
{
    public interface ITaxaDeJurosServices
    {
        decimal GetValor();

        Task<TaxaDeJurosDto> GetValorAsync(TaxaDeJurosDto taxaDeJurosDto, CancellationToken cancellationToken);
    }
}