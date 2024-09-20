using Ecommerce.Repository.Scarpa;
using Ecommerce.Service.ServizoScarpa;
using Ecommerce.Entities.InfoScarpe;
namespace Ecommerce.Service.SerivizioScarpa
{
    public class ScarpaService : IScarpaService
    {
        private readonly IScarpaRepository<Scarpa> _scarpaRepository;

    public ScarpaService(IScarpaRepository<Scarpa> scarpaRepository)
    {
        _scarpaRepository = scarpaRepository;
    }

    public async Task<IEnumerable<Scarpa>> GetAllScarpeAsync()
    {
        return await _scarpaRepository.GetAllAsync();
    }

    public async Task<Scarpa> GetScarpaByIdAsync(int id)
    {
        return await _scarpaRepository.GetByIdAsync(id);
    }

    public async Task AddScarpaAsync(Scarpa scarpa)
    {
        await _scarpaRepository.AddAsync(scarpa);
    }

    public async Task UpdateScarpaAsync(Scarpa scarpa)
    {
        await _scarpaRepository.UpdateAsync(scarpa);
    }

    public async Task DeleteScarpaAsync(int id)
    {
        await _scarpaRepository.DeleteAsync(id);
    }
    }
}