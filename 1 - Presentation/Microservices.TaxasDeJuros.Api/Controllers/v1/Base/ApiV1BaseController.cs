using Microsoft.AspNetCore.Mvc;

namespace Microservices.TaxasDeJuros.Api.Controllers.v1.Base
{
    [ApiController]
    [ApiVersion("1")]
    public abstract class ApiV1BaseController : ControllerBase
    {
    }
}