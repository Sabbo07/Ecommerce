using Ecommerce.Entities.Utenti;
using Ecommerce.Data;
namespace Ecommerce.Repository.Customer
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly EcommerceContext _context;

        public ClienteRepository(EcommerceContext context)
        {
            _context = context;
        }   

        public void Add(Cliente cliente)
        {
            _context.cliente.Add(cliente);
            _context.SaveChanges();
        }
        

    }
}