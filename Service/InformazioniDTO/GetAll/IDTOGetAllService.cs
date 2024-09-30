
using Ecommerce.Entities.InfoScarpe.DTO.GetAll;

namespace Ecommerce.Service.InformazioniDTO.GetAll
{
    public interface IDTOGetAllService
    {
        Task<IEnumerable<CategoriaDTOGetAll>> GetAllCategoriaAsync();
        Task<IEnumerable<BrandDTOGetAll>> GetAllBrandAsync();
        Task<IEnumerable<ModelloDTOGetAll>> GetAllModelloAsync();
        Task<IEnumerable<TagliaDTOGetAll>> GetAllTagliaAsync();
        Task<IEnumerable<ColoreDTOGetAll>> GetAllColoreAsync();

    }
}