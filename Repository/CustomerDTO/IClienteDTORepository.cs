using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.Utenti;
using Ecommerce.Entities.Utenti.CustomerDTO;

namespace Ecommerce.Repository.CustomerDTO
{
    public interface IClienteDTORepository
    {
        Task<Cliente> GetClienteByEmailAsync(string email);
        Task AddClienteAsync(Cliente cliente);
        Task SaveChangesAsync();
        public ClienteDTOLogin GetByEmail(string email);
    }
}