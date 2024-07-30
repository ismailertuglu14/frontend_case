using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.DTOs.User;
using Shop.Services.IServices;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetUser();
            if (result.StatusCode == Core.DTOs.Base.StatusCodes.SUCCESS) return Ok(result);
            else return BadRequest(result);
        }
        [HttpPost("signin")]
        public async Task<IActionResult> Signin(SigninDto dto)
        {
            var result = await _service.Signin(dto);
            if (result.StatusCode == Core.DTOs.Base.StatusCodes.SUCCESS) return Ok(result);
            else if (result.StatusCode == Core.DTOs.Base.StatusCodes.SERVER_ERROR) return StatusCode(500, result);
            else return BadRequest(result);
        }
        [HttpPost("signup")]
        public async Task<IActionResult> Signup(SignupDto dto)
        {
            var result = await _service.Signup(dto);
            if (result.StatusCode == Core.DTOs.Base.StatusCodes.SUCCESS) return Ok(result);
            else if (result.StatusCode == Core.DTOs.Base.StatusCodes.SERVER_ERROR) return StatusCode(500, result);
            else return BadRequest(result);
        }
    }
}
