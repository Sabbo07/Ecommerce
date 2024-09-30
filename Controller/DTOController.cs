using Ecommerce.Entities.InfoScarpe.DTO;
using Ecommerce.Entities.InfoScarpe.DTO.Update;
using Ecommerce.Service.InformazioniDTO;
using Ecommerce.Service.InformazioniDTO.GetAll;
using Ecommerce.Service.InformazioniDTO.Update;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class DTOController : ControllerBase
    {
        private readonly IDTOService _DTOService;
        private readonly IDTOUpdateService _DTOUpdateService;
        private readonly IDTOGetAllService _DTOGetAllService;
        public DTOController(IDTOService DTOService, IDTOUpdateService DTOUpdateService, IDTOGetAllService DTOGetAllService)
        {
            _DTOService = DTOService;
            _DTOUpdateService = DTOUpdateService;
            _DTOGetAllService = DTOGetAllService;
        }

        [HttpPost("add-categoria")]
        public async Task<IActionResult> AddCategoria([FromBody] CategoriaDTO categoriaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _DTOService.AddCategoriaAsync(categoriaDto);
            return Ok("Categoria added successfully.");
        }
        [HttpPost("add-brand")]
        public async Task<IActionResult> AddBrand([FromBody] BrandDTO brandDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _DTOService.addBrandAsync(brandDto);
            return Ok("Brand added successfully.");
        }
        [HttpPost("add-modello")]
        public async Task<IActionResult> AddModello([FromBody] ModelloDTO modelloDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _DTOService.addModelloAsync(modelloDTO);
            return Ok("Modello added successfully.");
        }
        [HttpPost("add-colore")]
        public async Task<IActionResult> AddColore([FromBody] ColoreDTO coloreDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _DTOService.addColoreAsync(coloreDTO);
            return Ok("Colore added successfully.");
        }
        [HttpPost("add-taglia")]
        public async Task<IActionResult> AddTaglia([FromBody] TagliaDTO tagliaDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _DTOService.addTagliaAsync(tagliaDTO);
            return Ok("Taglia added successfully.");
        }
        [HttpPut("categoria/update")]
        public async Task<IActionResult> UpdateCategoria([FromBody] CategoriaDTOUpdate categoriaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updated = await _DTOUpdateService.UpdateCategoriaAsync(categoriaDto);
            if (!updated)
            {
                return NotFound("Categoria not found.");
            }

            return Ok("Categoria updated successfully.");
        }
        [HttpPut("modello/update")]
        public async Task<IActionResult> UpdateModello([FromBody] ModelloDTOUpdate modelloDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updated = await _DTOUpdateService.UpdateModelloAsync(modelloDto);
            if (!updated)
            {
                return NotFound("Modello not found.");
            }

            return Ok("Modello updated successfully.");
        }
        [HttpPut("brand/update")]
        public async Task<IActionResult> UpdateBrand([FromBody] BrandDTOUpdate brandDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updated = await _DTOUpdateService.UpdateBrandAsync(brandDto);
            if (!updated)
            {
                return NotFound("Brand not found.");
            }

            return Ok("Brand updated successfully.");
        }
        [HttpPut("colore/update")]
        public async Task<IActionResult> UpdateColore([FromBody] ColoreDTOUpdate coloreDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updated = await _DTOUpdateService.UpdateColoreAsync(coloreDto);
            if (!updated)
            {
                return NotFound("Colore not found.");
            }
            return Ok("Colore updated successfully.");
        }
        [HttpPut("taglia/update")]
        public async Task<IActionResult> UpdateTaglia([FromBody] TagliaDTOUpdate tagliaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updated = await _DTOUpdateService.UpdateTagliaAsync(tagliaDto);
            if (!updated)
            {
                return NotFound("Colore not found.");
            }
            return Ok("Colore updated successfully.");
        }
        [HttpGet("GetAllCategoria")]
        public async Task<IActionResult> GetAllCategoria()
        {
            var categoria = await _DTOGetAllService.GetAllCategoriaAsync();
            return Ok(categoria);  // Returns 200 OK with the list of categories
        }
        [HttpGet("GetAllBrand")]
        public async Task<IActionResult> GetAllBrand()
        {
            var brand = await _DTOGetAllService.GetAllBrandAsync();
            return Ok(brand);  // Returns 200 OK with the list of brands
        }
        [HttpGet("GetAllModello")]
        public async Task<IActionResult> GetAllModello()
        {
            var modello = await _DTOGetAllService.GetAllModelloAsync();
            return Ok(modello);  // Returns 200 OK with the list of models
        }
        [HttpGet("GetAllTaglia")]
        public async Task<IActionResult> GetAllTaglia()
        {
            var taglia = await _DTOGetAllService.GetAllTagliaAsync();
            return Ok(taglia);  // Returns 200 OK with the list of sizes
        }
        [HttpGet("GetAllColore")]
        public async Task<IActionResult> GetAllColore()
        {
            var colore = await _DTOGetAllService.GetAllColoreAsync();
            return Ok(colore);  // Returns 200 OK with the list of colors
        }
    }
}






