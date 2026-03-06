using API_CICD.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BonjourController : ControllerBase
    {
        private readonly IAdditionService _additionService;

        public BonjourController(IAdditionService additionService)
        {
            _additionService = additionService;

        }


        string Message = "Bonjour";

        [HttpGet(Name = "CICD")]
        public IActionResult GetBonjour()
        {
            return Ok(new { message = $"{Message} {_additionService} " });

        }

        [HttpGet(Name = "Addition")]
        public IActionResult GetAddition()
        {



            return Ok(new { _additionService });





        }
    }
}
