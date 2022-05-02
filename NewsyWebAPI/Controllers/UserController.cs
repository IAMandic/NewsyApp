using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsyWebAPI.Repositories;

namespace NewsyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                var users = _userRepository.GetUsers();
                return Ok(users);   
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
