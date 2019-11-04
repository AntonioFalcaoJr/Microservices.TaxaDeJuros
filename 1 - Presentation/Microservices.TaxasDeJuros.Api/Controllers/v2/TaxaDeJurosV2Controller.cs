using Microservices.TaxasDeJuros.Api.Controllers.v2.Base;
using Microservices.TaxasDeJuros.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.TaxasDeJuros.Api.Controllers.v2
{
    [ApiVersion("2")]
    [Route("v{version:apiVersion}/taxaJuros")]
    public class TaxaDeJurosV2Controller : ApiV2BaseController
    {
        private readonly ITaxaDeJurosServices _taxaDeJurosServices;

        public TaxaDeJurosV2Controller(ITaxaDeJurosServices taxaDeJurosServices)
        {
            _taxaDeJurosServices = taxaDeJurosServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] Guid id, CancellationToken cancellationToken)
        {
            if (id == Guid.Empty)
                return BadRequest("Não foi possível identificar a Taxa de Juros desejada.");

            try
            {
                var result = await _taxaDeJurosServices.GetValorAsync(id, cancellationToken);

                if (result.IsValid())
                    return Ok(result.Valor);

                return BadRequest(result.GetErrors());
            }
            catch (Exception e)
            {
                return BadRequest("Não foi possível processar a solicitação. Menssagem do erro: " + e.Message);
            }
        }
    }
}