using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Service.Listadeidesideri
{
    public interface ILLDService
    {
        Task AddScarpaToWishlistAsync(int clienteId, int scarpaId, int quantita);
    }
}