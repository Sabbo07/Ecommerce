using Ecommerce.Entities.Utenti;
using Ecommerce.Entities.Utenti.CustomerDTO;

namespace Ecommerce.Service.CustomerDTO
{
    public interface IClienteDTOService
    {
        Task RegisterClienteAsync(ClienteDTO clienteDto);
        ClienteDTO Login(string email, string password);
    }
}