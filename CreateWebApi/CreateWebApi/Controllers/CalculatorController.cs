using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [FromQuery]
        public decimal input1 { get; set; }
        [FromQuery]
        public decimal input2 { get; set; }
        [HttpGet]
        public IEnumerable<Calculator> Get([FromQuery] decimal input1, [FromQuery] decimal input2)
        {
            return Enumerable.Range(1, 1).Select(index => new Calculator
            {
                Addition = input1 + input2,
                Subtraction = input1 - input2,
                Multiplication = input1 * input2,
                Division = input1 / input2
            })
            .ToArray();
        }
    }
}
