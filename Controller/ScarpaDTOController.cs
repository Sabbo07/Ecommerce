
using Ecommerce.Entities.InfoScarpe.DTO;
using Ecommerce.Service.DTOService;
using Ecommerce.Service.ServizoScarpa;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controller
{


    [ApiController]
    [Route("api/[controller]")]
    public class ScarpaDTOController : ControllerBase
    {
        private readonly IScarpaDTOService _scarpaDTOService;
        private readonly IScarpaService _scarpaService;

        public ScarpaDTOController(IScarpaDTOService scarpaDTOService, IScarpaService scarpaService)
        {
            _scarpaDTOService = scarpaDTOService;
            _scarpaService = scarpaService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetScarpaById(int id)
        {
            Console.WriteLine("Scarpa non trovata");
            var scarpaDto = await _scarpaDTOService.GetScarpaDtoByIdAsync(id);

            if (scarpaDto == null)
            {

                return NotFound();
            }

            return Ok(scarpaDto);
        }
        [HttpGet("GetAllScarpe")]
        public async Task<IActionResult> GetAllScarpe()
        {
            var scarpeDto = await _scarpaDTOService.GetAllScarpeDtoAsync();
            return Ok(scarpeDto);
        }
        [HttpGet("modello/{scarpaModello}")]
        public async Task<ActionResult<List<ScarpaDTO>>> GetByModelloScarpa(string scarpaModello)
        {
            if (string.IsNullOrWhiteSpace(scarpaModello))
            {
                return BadRequest("Il nome del modello non può essere vuoto o nullo.");
            }

            var scarpe = await _scarpaService.GetByModelloNomeAsync(scarpaModello);

            if (scarpe == null || !scarpe.Any())
            {
                return NotFound($"Nessuna scarpa trovata con il modello contenente: '{scarpaModello}'.");
            }

            var scarpaDtos = scarpe.Select(s => new ScarpaDTO
            {
                NomeModello = s.Modello.Nome,
                NomeBrand = s.Brand.Nome,
                NomeColore = s.Colore.Nome,
                NomeCategoria = s.Categoria.Nome,
                NumeroTaglia = s.DettagliScarpe.FirstOrDefault()?.Taglia.Numero // Adjust based on your data
            }).ToList();

            return Ok(scarpaDtos);
        }

        [HttpDelete("delete-scarpa/{scarpaId}")]
public async Task<IActionResult> DeleteScarpa(int scarpaId)
{
    try
    {
        bool isDeleted = await _scarpaDTOService.DeleteScarpaAsync(scarpaId);
        if (!isDeleted)
        {
            return NotFound("Scarpa not found.");
        }

        return Ok("Scarpa deleted successfully.");
    }
    catch (Exception ex)
    {
        return BadRequest(ex.Message);  // Handle any unexpected errors
    }
}




    }

}
