using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.InfoUtente;
using Ecommerce.Entities.Listadesideri;

namespace Ecommerce.Repository.Listadeidesideri
{
    public interface ILDDRepository
    {
       Task<Whislist> GetListadeidesideriAsync(int clienteId);
       Task AddListadeidesideriAsync(Whislist whislist);
       Task UpdateListadeidesideriAsync(Whislist whislist);
       Task SaveChangesAsync();
       
    }
}