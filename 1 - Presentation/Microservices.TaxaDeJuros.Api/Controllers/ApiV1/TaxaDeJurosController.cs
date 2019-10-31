using CalculadoraDeJuros.Dto;
using Microservices.TaxasDeJuros.Api.Controllers.ApiV1.Base;
using Microservices.TaxasDeJuros.Services.TaxasDeJurosPadrao;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.TaxasDeJuros.Api.Controllers.ApiV1
{
    [Route("v{version:apiVersion}/taxaDeJuros")]
    public class TaxaDeJurosController : ApiV1BaseController
    {
        private readonly ITaxaDeJurosPadraoServices _taxaDeJurosPadraoServices;

        public TaxaDeJurosController(ITaxaDeJurosPadraoServices taxaDeJurosPadraoServices)
        {
            _taxaDeJurosPadraoServices = taxaDeJurosPadraoServices;
        }

        [HttpGet]
        public IActionResult GetAsync([FromQuery]TaxaDeJurosDto dto) =>
            dto is null
                ? (IActionResult)BadRequest("deu ruim negão")
                : Ok(_taxaDeJurosPadraoServices.GetValor());
    }
}