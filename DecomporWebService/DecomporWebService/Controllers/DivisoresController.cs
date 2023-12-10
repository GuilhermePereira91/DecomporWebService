using DecomporWebService.Models;
using DecomporWebService.Services.DivisoresService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DecomporWebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DivisoresController : ControllerBase
    {
        private readonly ILogger<DivisoresController> _logger;
        private IDivisoresService _divisoresService;

        public DivisoresController(ILogger<DivisoresController> logger, IDivisoresService divisoresService)
        {
            _logger = logger;
            _divisoresService = divisoresService;
        }

        [HttpPost("obtertodos")]
        public IActionResult ObterTodos([FromBody] int numero)
        {
            if (numero <= 0)
                return BadRequest("Valor inválido. O número deverá ser maior que zero e inteiro.");

            return Ok(_divisoresService.ObterTodos(numero));
        }

        [HttpPost("obternaturais")]
        public IActionResult ObterNaturais([FromBody] int numero)
        {
            if (numero <= 0)
                return BadRequest("Valor inválido. O número deverá ser maior que zero e inteiro.");

            return Ok(_divisoresService.ObterNaturais(numero));
        }

        [HttpPost("obterprimos")]
        public IActionResult ObterPrimos([FromBody] int numero)
        {
            if (numero <= 0)
                return BadRequest("Valor inválido. O número deverá ser maior que zero e inteiro.");

            return Ok(_divisoresService.ObterPrimos(numero));
        }
    }
}
