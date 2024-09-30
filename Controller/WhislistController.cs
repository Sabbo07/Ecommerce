using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Service.Listadeidesideri;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class WhislistController : ControllerBase
    {
        private readonly ILLDService _lldService;

        public WhislistController(ILLDService lldService)
        {
            _lldService = lldService;
        }


        [HttpPost("add-to-wishlist")]
        public async Task<IActionResult> AddToWishlist(int clienteId, int scarpaId, int quantita)
        {
            if (quantita <= 0)
            {
                return BadRequest("Quantità deve essere maggiore di zero.");
            }

            try
            {
                await _lldService.AddScarpaToWishlistAsync(clienteId, scarpaId, quantita);
                return Ok("Scarpa aggiunta alla lista dei desideri con successo.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }   
    }
}