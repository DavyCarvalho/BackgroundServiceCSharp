using BackgroundServiceExample.Data.Interfaces;
using BackgroundServiceExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackgroundServiceExample.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase 
    {
        private readonly IBackgroundProccessRepository _backgroundProccessRepository;
        public ProcessController(IBackgroundProccessRepository backgroundProccessRepository)
        {
            _backgroundProccessRepository = backgroundProccessRepository;
        }

        [HttpGet("{filterLetter}")]
        public ActionResult RequestUsersThatNameStartsWithParameter([FromRoute] string filterLetter)
        {
            var backgroundProccess = new BackgroundProccess() 
            {
                Id = Guid.NewGuid(),
                NameSearchParameter = filterLetter
            };

            _backgroundProccessRepository.RegisterBackgroundProcess(backgroundProccess);

            return Ok("Searching for users ");
        }
    }
}
