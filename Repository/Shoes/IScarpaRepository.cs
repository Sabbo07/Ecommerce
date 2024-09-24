using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Repository.Shoes
{
    public interface IScarpaRepository
    {
    Task<IEnumerable<Scarpa>> GetAllScarpeAsync();
    Task<Scarpa> GetScarpaByIdAsync(int id);
    Task<Scarpa> AddScarpaAsync(Scarpa scarpa);
    Task<Scarpa> UpdateScarpaAsync(Scarpa scarpa);

    Task DeleteScarpaAsync(int id);




    void AddScarpa(Scarpa scarpa);
    public List<Scarpa> GetByModelloNome(string modelloNome);
    Task<List<Scarpa>> GetByModelloNomeAsync(string modelloNome);

    }
}


//le classi generiche vengono usate per manipolare i dati

//sopratutto quando si fa operazioni perlappunto generiche ed 
//che possono essere applicate a piur tipi di dati

