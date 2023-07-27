using FuzzyAPI.Models;
using FuzzyAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FuzzyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuzzyController : ControllerBase
    {
        private readonly ILogger<FuzzyController> _logger;
        private readonly IFuzzyService _fuzzyService;

        public FuzzyController(ILogger<FuzzyController> logger, IFuzzyService fuzzyService)
        {
            _logger = logger;
            _fuzzyService = fuzzyService;
        }

        /// <summary>
        /// Returns the closest option to the input, using fuzzy sharp to calculate that
        /// </summary>
        /// <param name="request"></param>
        /// <returns name="fuzzyResponse"></returns>
        [HttpPost("/api/ExtractOne-Score")]
        [ProducesResponseType(200, Type = typeof(FuzzyResponse))]
        [ProducesResponseType(400)]
        public IActionResult FuzzyOne([FromBody] FuzzyRequest request)
        {
            if (request.GetType().GetProperties().Any(p => p.GetValue(request) == null))
            {
                return BadRequest();
            }            
            
            return Ok(_fuzzyService.ExtractOne(request));
        }

    }
}