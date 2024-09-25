using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.Utenti;

namespace Ecommerce.Service.Customer
{
    public interface IClienteService
    {
        public void CreateCustomer(Cliente cliente);
    }
}