using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.InfoScarpe.DTO;

namespace Ecommerce.Service.InformazioniDTO
{
    public interface IDTOService
    {
        Task AddCategoriaAsync(CategoriaDTO categoriaDto);
        Task addBrandAsync(BrandDTO brandDto);
        Task addModelloAsync(ModelloDTO modelloDTO);
        Task addColoreAsync(ColoreDTO coloreDTO);
        Task addTagliaAsync(TagliaDTO tagliaDTO);
    }
}