using Microsoft.AspNetCore.Mvc;
using Ecommerce.Entities.Utenti;

[ApiController]
[Route("api/[controller]")]
public class MagazziniereController : ControllerBase
{
    private readonly IMagazziniereService _service;

    public MagazziniereController(IMagazziniereService service)
    {
        _service = service;
    }

    [HttpPost("Register")]
    public IActionResult CreateMagazziniere([FromBody] Magazziniere magazziniere)
    {
        if (magazziniere == null)
        {
            return BadRequest("Invalid data.");
        }

        // You might want to add validation here as well

        _service.CreateMagazziniere(magazziniere);
        return CreatedAtAction(nameof(CreateMagazziniere), new { id = magazziniere.Id }, magazziniere);
    }
    [HttpPost("login")]
public IActionResult Login([FromBody] LoginRequest request)
{
    if (request == null || string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
    {
        return BadRequest("Invalid data.");
    }

    var magazziniere = _service.Login(request.Email, request.Password);
    if (magazziniere == null)
    {
        return Unauthorized("Invalid email or password.");
    }

    // Return the ID of the logged-in user
    return Ok(new { Id = magazziniere.Id });
}

// Define a LoginRequest class to handle login data
public class LoginRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
}

}
