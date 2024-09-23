using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.InfoScarpe.DTO;

namespace Ecommerce.Service.DTOService
{
    public interface IScarpaDTOService
    {
        Task<ScarpaDTO> GetScarpaDtoByIdAsync(int id);
    }
}