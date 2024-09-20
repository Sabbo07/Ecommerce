using Ecommerce.Entities.InfoScarpe;
namespace Ecommerce.Service.ServizoScarpa
{
    public interface IScarpaService
    {
        Task<IEnumerable<Scarpa>> GetAllScarpeAsync();
        Task<Scarpa> GetScarpaByIdAsync(int id);
        Task AddScarpaAsync(Scarpa scarpa);
        Task UpdateScarpaAsync(Scarpa scarpa);
        Task DeleteScarpaAsync(int id);
    }
}

// le task sono usate per fare asincronismo
//Gli IEnumeable sono usati per iterare su una collezione di oggetti
