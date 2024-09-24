using Microsoft.AspNetCore.Mvc;
using Ecommerce.Service.Carrello;

[ApiController]
[Route("api/[controller]")]
public class CarrelloController : ControllerBase
{
    private readonly ICarrelloService _carrelloService;

    public CarrelloController(ICarrelloService carrelloService)
    {
        _carrelloService = carrelloService;
    }

    [HttpPost("add-to-cart")]
    public async Task<IActionResult> AddToCart(int clienteId, int scarpaId, int quantita)
    {
        if (quantita <= 0)
        {
            return BadRequest("Quantità deve essere maggiore di zero.");
        }

        try
        {
            await _carrelloService.AddScarpaToCartAsync(clienteId, scarpaId, quantita);
            return Ok("Scarpa aggiunta al carrello con successo.");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
