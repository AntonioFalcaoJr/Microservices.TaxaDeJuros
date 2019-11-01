using CalculadoraDeJuros.Dto;
using Microservices.TaxasDeJuros.Api.Controllers.ApiV1.Base;
using Microservices.TaxasDeJuros.Services.TaxasDeJurosPadrao;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.TaxasDeJuros.Api.Controllers.ApiV1
{
    [Route("v{version:apiVersion}/taxaJuros")]
    public class TaxaDeJurosController : ApiV1BaseController
    {
        private readonly ITaxaDeJurosPadraoServices _taxaDeJurosPadraoServices;

        public TaxaDeJurosController(ITaxaDeJurosPadraoServices taxaDeJurosPadraoServices)
        {
            _taxaDeJurosPadraoServices = taxaDeJurosPadraoServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] TaxaDeJurosDto taxaDeJurosDto, CancellationToken cancellationToken)
        {
            if (taxaDeJurosDto is null)
                return BadRequest("Não foi possível identificar a Taxa de Juros desejada.");

            return Ok(await _taxaDeJurosPadraoServices.GetValorAsync(cancellationToken));
        }
    }
}