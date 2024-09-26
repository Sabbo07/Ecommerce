using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.InfoScarpe.DTO;
using Ecommerce.Service.InformazioniDTO;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class DTOController : ControllerBase
    {
        private readonly IDTOService _DTOService;

        public DTOController(IDTOService DTOService)
        {
            _DTOService = DTOService;
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
    }
}






