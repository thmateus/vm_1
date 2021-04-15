using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSoftplan.CalculoJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {

        private readonly ILogger<TaxaJurosController> _logger;

        public TaxaJurosController(ILogger<TaxaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [SwaggerOperation(OperationId = "taxaJuros")]
        [Route("taxaJuros")]
        public async Task<IActionResult> TaxaJuros()
        {
            return new OkObjectResult(0.01m);
        }

        [HttpGet]
        [SwaggerOperation(OperationId = "taxaJurosPerc")]
        [Route("taxaJurosPerc")]
        public async Task<IActionResult> TaxaJurosPerc()
        {
            return new OkObjectResult("1%");
        }
    }
}
