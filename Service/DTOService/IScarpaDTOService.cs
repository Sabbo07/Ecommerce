using Ecommerce.Entities.InfoScarpe.DTO;
namespace Ecommerce.Service.DTOService
{
    public interface IScarpaDTOService
    {
       Task<ScarpaDTO> GetScarpaDtoByIdAsync(int id);
       Task<IEnumerable<ScarpaDTO>> GetAllScarpeDtoAsync();
       Task<IEnumerable<ScarpaSearchResultDTO>> SearchScarpeByModelloNameAsync(ScarpaSearchDTO searchDto);
       Task<bool> DeleteScarpaAsync(int scarpaId);
    }
}