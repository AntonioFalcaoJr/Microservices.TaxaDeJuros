using Microservices.TaxasDeJuros.Api.Controllers.ApiV1.Base;
using Microservices.TaxasDeJuros.Services.TaxasDeJurosPadrao;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;

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
        public double Get(CancellationToken cancellationToken)
        {
            try
            {
                return _taxaDeJurosPadraoServices.GetValor();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}