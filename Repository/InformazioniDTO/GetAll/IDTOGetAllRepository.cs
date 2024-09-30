using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Repository.InformazioniDTO.GetAll
{
    public interface IDTOGetAllRepository
    {
        Task<IEnumerable<Categoria>> GetAllCategoriasAsync();
        Task<IEnumerable<Brand>> GetAllBrandsAsync();
        Task<IEnumerable<Modello>> GetAllModelliAsync();
        Task<IEnumerable<Taglia>> GetAllTaglieAsync();
        Task<IEnumerable<Colore>> GetAllColoriAsync();
    }
}