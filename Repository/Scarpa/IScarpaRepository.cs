using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.Scarpa
{
    public interface IScarpaRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}


//le classi generiche vengono usate per manipolare i dati

//sopratutto quando si fa operazioni perlappunto generiche ed 
//che possono essere applicate a piur tipi di dati

