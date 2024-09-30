
using Ecommerce.Entities.InfoScarpe.DTO.Update;

namespace Ecommerce.Service.InformazioniDTO.Update
{
    public interface IDTOUpdateService
    {
        Task<bool> UpdateBrandAsync(BrandDTOUpdate dto);
        Task<bool> UpdateCategoriaAsync(CategoriaDTOUpdate dto);
        Task<bool> UpdateModelloAsync(ModelloDTOUpdate dto);
        Task<bool> UpdateColoreAsync(ColoreDTOUpdate dto);
        Task<bool> UpdateTagliaAsync(TagliaDTOUpdate dto);
    }
}