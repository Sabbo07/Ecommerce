using Microsoft.AspNetCore.Mvc;
using Ecommerce.Service.ServizoScarpa;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScarpeController : ControllerBase
    {
        private readonly IScarpaService _scarpaService;

        public ScarpeController(IScarpaService scarpaService)
        {
            _scarpaService = scarpaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scarpa>>> GetScarpe()
        {
            var scarpe = await _scarpaService.GetAllScarpeAsync();
            return Ok(scarpe);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Scarpa>> GetScarpa(int id)
        {
            var scarpa = await _scarpaService.GetScarpaByIdAsync(id);
            if (scarpa == null)
            {
                return NotFound();
            }
            return Ok(scarpa);
        }

        [HttpPost]
        public async Task<ActionResult> PostScarpa(Scarpa scarpa)
        {
            await _scarpaService.AddScarpaAsync(scarpa);
            return CreatedAtAction(nameof(GetScarpa), new { id = scarpa.Id }, scarpa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutScarpa(int id, Scarpa scarpa)
        {
            if (id != scarpa.Id)
            {
                return BadRequest();
            }

            await _scarpaService.UpdateScarpaAsync(scarpa);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScarpa(int id)
        {
            await _scarpaService.DeleteScarpaAsync(id);
            return NoContent();
        }
    }
}