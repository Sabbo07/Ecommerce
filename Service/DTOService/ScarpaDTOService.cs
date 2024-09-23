using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Entities.InfoScarpe.DTO;
using Ecommerce.Repository.Shoes;

namespace Ecommerce.Service
{
    public class ScarpaDTOService
    {

        private readonly IScarpaRepository _scarpaRepository;

    public ScarpaDTOService(IScarpaRepository scarpaRepository)
    {
        _scarpaRepository = scarpaRepository;
    }
       public async Task<ScarpaDTO> GetScarpaDtoByIdAsync(int id)
{
    // Fetch the entity from the repository
    var scarpa = await _scarpaRepository.GetScarpaByIdAsync(id);
    
    if (scarpa == null) return null;

    // Map to DTO
    var scarpaDto = new ScarpaDTO
{
    ModelloId = scarpa.ModelloId,
    BrandId = scarpa.BrandId,
    CategoriaId = scarpa.CategoriaId,
    ColoreId = scarpa.ColoreId,
    Dettagli = scarpa.DettagliScarpe.Select(d => new DettagliScarpaDTO
    {
        TagliaId = d.TagliaId,
        QtaTaglia = d.QtaTaglia,
        Prezzo = d.Prezzo,
        Sconto = d.Sconto
    }).ToList()
};

    return scarpaDto;
}

    }
}