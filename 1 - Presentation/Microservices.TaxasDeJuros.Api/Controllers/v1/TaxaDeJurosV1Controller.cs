using Microservices.TaxasDeJuros.Api.Controllers.v1.Base;
using Microservices.TaxasDeJuros.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Microservices.TaxasDeJuros.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("v{version:apiVersion}/taxaJuros")]
    public class TaxaDeJurosV1Controller : ApiV1BaseController
    {
        private readonly ITaxaDeJurosServices _taxaDeJurosServices;

        public TaxaDeJurosV1Controller(ITaxaDeJurosServices taxaDeJurosServices)
        {
            _taxaDeJurosServices = taxaDeJurosServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_taxaDeJurosServices.GetValor());
            }
            catch (Exception e)
            {
                return BadRequest("Não foi possível processar a solicitação. Menssagem do erro: " + e.Message);
            }
        }
    }
}