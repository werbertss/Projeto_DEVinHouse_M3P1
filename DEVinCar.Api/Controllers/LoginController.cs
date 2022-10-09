using DEVinCar.Domain.DTOs;
using DEVinCar.Domain.Services;
using DEVinCar.Infra.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DEVinCar.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] UserLoginDTO dto)
        {
            var user = LoginRepository.VerificarEmailESenha(dto);

            if (user == null) return NotFound();

            var token = TokenService.GenerateToken(user);

            return Ok(token);
        }
    }
}
