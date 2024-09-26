
using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Entities.InfoScarpe.DTO;

namespace Ecommerce.Repository.ShoesDTO
{
    public interface IScarpaDTORepository
    {
        Task<IEnumerable<Scarpa>> SearchScarpeByModelloNameAsync(ScarpaSearchDTO searchDto);
        Task DeleteScarpaAsync(Scarpa scarpa);
    }
}