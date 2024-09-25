using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.Utenti;
using Ecommerce.Service.Customer;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }   

        [HttpPost("Register")]
        public IActionResult CreateCustomer([FromBody] Cliente cliente)
    {
        if (cliente == null)
        {
            return BadRequest("Invalid data.");
        }

        // You might want to add validation here as well

        clienteService.CreateCustomer(cliente);
        return CreatedAtAction(nameof(CreateCustomer), new { id = cliente.Id }, cliente);
    }
    }
}