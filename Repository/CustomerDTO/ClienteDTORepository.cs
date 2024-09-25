using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Entities.Utenti;
using Ecommerce.Entities.Utenti.CustomerDTO;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.CustomerDTO
{
    public class ClienteDTORepository : IClienteDTORepository
    {
        private readonly EcommerceContext _context;

        public ClienteDTORepository(EcommerceContext context)
        {
            _context = context;
        }

        // Fetch a customer by their email address
        public async Task<Cliente> GetClienteByEmailAsync(string email)
        {
            return await _context.cliente.FirstOrDefaultAsync(c => c.Email == email);
        }

        // Add a new customer to the database
        public async Task AddClienteAsync(Cliente cliente)
        {
            await _context.cliente.AddAsync(cliente);
        }

        // Save any changes made to the database
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        public ClienteDTO GetByEmail(string email)
{
    // Retrieve the Cliente entity based on the email
    var cliente = _context.cliente.SingleOrDefault(m => m.Email == email);

    // If no Cliente is found, return null (or handle it differently based on your needs)
    if (cliente == null)
    {
        return null; // Or throw an exception or handle the case appropriately
    }

    // Map Cliente entity to ClienteDTO
    var clienteDto = new ClienteDTO
    {
        Id = cliente.Id,
        Nome = cliente.Nome,
        Email = cliente.Email,
        // Map other properties from Cliente to ClienteDTO as needed
    };

    // Return the mapped ClienteDTO
    return clienteDto;
}

    }
}