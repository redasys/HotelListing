using HotelListingApi.Interfaces;
using HotelListingApi.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelListingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthManager _authManager;

        public AuthController(IAuthManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<AuthResponseDto>> Login(ApiLoginDto apiLoginDto)
        {
            var authResponse = await _authManager.Login(apiLoginDto);

            if (authResponse == null) return Unauthorized();

            return Ok(authResponse);
        }

        // api/Auth/register
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Register([FromBody] ApiUserDto apiUserDto)
        {
            var errors = await _authManager.Register(apiUserDto);

            if (errors.Any())
            {
                errors.ToList().ForEach(x => ModelState.AddModelError(x.Code, x.Description));
                return BadRequest(ModelState);
            }

            return Ok();
        }

        [HttpPost]
        [Route("refreshtoken")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> RefreshToken([FromBody] AuthResponseDto requestDto)
        {
            var authResponse = await _authManager.VerifyRefreshToken(requestDto);

            if (authResponse==null)
            {
                return Unauthorized();
            }

            return Ok(authResponse);
        }
    }
}
