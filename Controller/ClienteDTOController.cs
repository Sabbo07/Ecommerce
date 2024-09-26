
using Ecommerce.Entities.Utenti.CustomerDTO;

using Ecommerce.Service.CustomerDTO;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteDTOController : ControllerBase
    {
        private readonly IClienteDTOService _clienteDTOService;

        public ClienteDTOController(IClienteDTOService _clienteDTOService)
        {
            this._clienteDTOService = _clienteDTOService;
        }

        // POST: api/Cliente/register
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] ClienteDTO clienteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _clienteDTOService.RegisterClienteAsync(clienteDto);
                return Ok("Cliente registrato con successo.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  // Handle error
            }
        }
        
        [HttpPost("login")]
        public  IActionResult Login([FromBody] LoginRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
            {
                return BadRequest("Invalid data.");
            }

            var ClienteDTOLogin = _clienteDTOService.Login(request.Email, request.Password);
            if (ClienteDTOLogin == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            // Return the ID of the logged-in user
            return Ok(new { Id = ClienteDTOLogin.Id });
        }
        
    }
    
    public class LoginRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
}
}