using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Repository.InformazioniDTO.Update
{
    public interface IDTOUpdateRepository
    {
        Task<Categoria> GetCategoriaByIdAsync(int id);
        Task UpdateCategoriaAsync(Categoria categoria);
        Task SaveAsync();
        Task<Modello> GetModelloByIdAsync(int id);
        Task UpdateModelloAsync(Modello modello);
        Task<Brand> GetBrandByIdAsync(int id);
        Task UpdateBrandAsync(Brand brand);
        Task<Colore> GetColoreByIdAsync(int id);
        Task UpdateColoreAsync(Colore colore);
        Task<Taglia> GetTagliaByIdAsync(int id);
        Task UpdateTagliaAsync(Taglia taglia);
    }
}