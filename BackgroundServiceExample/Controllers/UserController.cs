using BackgroundServiceExample.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackgroundServiceExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet()]
        public ActionResult GetAllUsers()
        {
            var result = _userRepository.GetAllUsers();

            return Ok(result);
        }
    }
}
