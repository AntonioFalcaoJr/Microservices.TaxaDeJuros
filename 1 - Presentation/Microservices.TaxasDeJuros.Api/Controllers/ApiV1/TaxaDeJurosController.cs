using CalculadoraDeJuros.Contratos.Dto;
using Microservices.TaxasDeJuros.Api.Controllers.ApiV1.Base;
using Microservices.TaxasDeJuros.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.TaxasDeJuros.Api.Controllers.ApiV1
{
    [Route("v{version:apiVersion}/taxaJuros")]
    public class TaxaDeJurosController : ApiV1BaseController
    {
        private readonly ITaxaDeJurosServices _taxaDeJurosServices;

        public TaxaDeJurosController(ITaxaDeJurosServices taxaDeJurosServices)
        {
            _taxaDeJurosServices = taxaDeJurosServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] TaxaDeJurosDto taxaDeJurosDto, CancellationToken cancellationToken)
        {
            if (taxaDeJurosDto is null)
                return BadRequest("Não foi possível identificar a Taxa de Juros desejada.");

            try
            {
                return Ok(await _taxaDeJurosServices.GetValorAsync(taxaDeJurosDto, cancellationToken));
            }
            catch (Exception e)
            {
                return BadRequest("Não foi possível processar a solicitação. Menssagem do erro: " + e.Message);
            }
        }
    }
}