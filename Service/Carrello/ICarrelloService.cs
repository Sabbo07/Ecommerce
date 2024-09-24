using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Service.Carrello
{
    public interface ICarrelloService
    {
        Task AddScarpaToCartAsync(int clienteId, int scarpaId, int quantita);
    }
}