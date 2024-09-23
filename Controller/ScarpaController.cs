using Microsoft.AspNetCore.Mvc;
using Ecommerce.Service.ServizoScarpa;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScarpaController : ControllerBase
    {
        private readonly IScarpaService _scarpaService;

    public ScarpaController(IScarpaService scarpaService)
    {
        _scarpaService = scarpaService;
    }

    // GET: api/scarpa
    [HttpGet("GetAllScarpe")]
    public async Task<IActionResult> GetAllScarpe()
    {
        var scarpe = await _scarpaService.GetAllScarpeAsync();
        return Ok(scarpe);
    }


    // GET: api/scarpa/{id}
    [HttpGet("GetProductByID/{id}")]
    public async Task<IActionResult> GetScarpaById(int id)
    {
        var scarpa = await _scarpaService.GetScarpaByIdAsync(id);
        if (scarpa == null)
        {
            return NotFound();
        }
        return Ok(scarpa);
    }


    [HttpOptions("{id}")]
     public async Task<IActionResult> GetScarpaById()
     {
            return Ok();
     }

    // POST: api/scarpa
    [HttpPost("CreateScarpa")]
public async Task<IActionResult> CreateScarpa([FromBody] Scarpa scarpa)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    try
    {
        var createdScarpa = await _scarpaService.CreateScarpaAsync(scarpa);
        return CreatedAtAction(nameof(GetScarpaById), new { id = createdScarpa.Id }, createdScarpa);
    }
    catch (Exception ex)
    {
        // Log the exception (consider using a logging framework)
        return StatusCode(500, $"Internal server error: {ex.Message}");
    }
}

    [HttpOptions("CreateScarpa")]
    public async Task<IActionResult> CreateScarpa()
    {
        return Ok();
    }



    // PUT: api/scarpa/{id}
    [HttpPut("Modify/{id}")]
    public async Task<IActionResult> UpdateScarpa(int id, [FromBody] Scarpa scarpa)
    {
        if (id != scarpa.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        var updatedScarpa = await _scarpaService.UpdateScarpaAsync(scarpa);
        return Ok(updatedScarpa);
    }

    // DELETE: api/scarpa/{id}
    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> DeleteScarpa(int id)
    {
        await _scarpaService.DeleteScarpaAsync(id);
        return NoContent();
    }


    [HttpPost("AggiungiScarpa")]
    public IActionResult AggiungiScarpa([FromBody] CreateScarpaRequest request)
    {
        _scarpaService.AggiungiScarpa(
            request.ModelloId,
            request.BrandId,
            request.CategoriaId,
            request.ColoreId,
            request.Dettagli);

        return CreatedAtAction(nameof(CreateScarpa), new { /* return details if needed */ });
    }


    }
    public class CreateScarpaRequest
{
    public int ModelloId { get; set; }
    public int BrandId { get; set; }
    public int CategoriaId { get; set; }
    public int ColoreId { get; set; }
    public List<DettaglioScarpaDto> Dettagli { get; set; }
}
}