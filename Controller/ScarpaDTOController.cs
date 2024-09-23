using Microsoft.AspNetCore.Mvc;
using Ecommerce.Service.ServizoScarpa;
using Ecommerce.Entities.InfoScarpe;

using Ecommerce.Service;
using Ecommerce.Service.DTOService;

namespace Ecommerce.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScarpaDTOController : ControllerBase
    {
         private readonly IScarpaDTOService _scarpaDTOService;

    public ScarpaDTOController(IScarpaDTOService _scarpaDTOService)
    {
        _scarpaDTOService = _scarpaDTOService;
    }
    [HttpGet("{id}")]
public async Task<IActionResult> GetScarpaById(int id)
{
    // Call the service layer to get the ScarpaDto
    var scarpaDto = await _scarpaDTOService.GetScarpaDtoByIdAsync(id);
    
    if (scarpaDto == null)
    {
        return NotFound();
    }

    // Return the DTO as a JSON response
    return Ok(scarpaDto);
}

    }
}