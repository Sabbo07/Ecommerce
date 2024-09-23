using Ecommerce.Repository.Shoes;
using Ecommerce.Service.ServizoScarpa;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Service.SerivizioScarpa
{
    public class ScarpaService : IScarpaService
    {
     private readonly IScarpaRepository _scarpaRepository;

    public ScarpaService(IScarpaRepository scarpaRepository)
    {
        _scarpaRepository = scarpaRepository;
    }

    public async Task<IEnumerable<Scarpa>> GetAllScarpeAsync()
    {
        return await _scarpaRepository.GetAllScarpeAsync();
    }

    public async Task<Scarpa> GetScarpaByIdAsync(int id)
    {
        return await _scarpaRepository.GetScarpaByIdAsync(id);
    }

    public async Task<Scarpa> CreateScarpaAsync(Scarpa scarpa)
    {
        return await _scarpaRepository.AddScarpaAsync(scarpa);
    }

    public async Task<Scarpa> UpdateScarpaAsync(Scarpa scarpa)
    {
        return await _scarpaRepository.UpdateScarpaAsync(scarpa);
    }

    public async Task DeleteScarpaAsync(int id)
    {
        await _scarpaRepository.DeleteScarpaAsync(id);
    }

    public void AggiungiScarpa(int modelloId, int brandId, int categoriaId, int coloreId, List<DettaglioScarpaDto> dettagli)
    {
        var scarpa = new Scarpa
        {
            ModelloId = modelloId,
            BrandId = brandId,
            CategoriaId = categoriaId,
            ColoreId = coloreId,
            DettagliScarpe = dettagli.Select(d => new DettagliScarpa
            {
                TagliaId = d.TagliaId,
                QtaTaglia = d.QtaTaglia,
                Prezzo = d.Prezzo,
                Sconto = d.Sconto
            }).ToList()
        };

        _scarpaRepository.AddScarpa(scarpa);
    }
    }
}