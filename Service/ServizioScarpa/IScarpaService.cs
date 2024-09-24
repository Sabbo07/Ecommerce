using Ecommerce.Entities.InfoScarpe;
namespace Ecommerce.Service.ServizoScarpa
{
    public interface IScarpaService
    {
        Task<IEnumerable<Scarpa>> GetAllScarpeAsync();
    Task<Scarpa> GetScarpaByIdAsync(int id);
    Task<Scarpa> CreateScarpaAsync(Scarpa scarpa);
    Task<Scarpa> UpdateScarpaAsync(Scarpa scarpa);
    Task DeleteScarpaAsync(int id);

    void AggiungiScarpa(int modelloId, int brandId, int categoriaId, int coloreId, List<DettaglioScarpaDto> dettagli);

    Task<List<Scarpa>> GetByModelloNomeAsync(string modelloNome);
    
    }
}
// le task sono usate per fare asincronismo
//Gli IEnumeable sono usati per iterare su una collezione di oggetti
