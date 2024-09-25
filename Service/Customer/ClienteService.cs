using Ecommerce.Entities.Utenti;
using Ecommerce.Repository.Customer;

namespace Ecommerce.Service.Customer
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }
        public void CreateCustomer(Cliente cliente)
        {
            clienteRepository.Add(cliente);
        }

    }
}