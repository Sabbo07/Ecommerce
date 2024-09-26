using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Repository.InformazioniDTO
{
    public interface IDTORepository
    {

        Task AddCategoriaAsync(Categoria categoria);
        Task<bool> ExistsByNameCAsync(string nome);
        Task AddBrandAsync(Brand brand);
        Task<bool> ExistsByNameBAsync(string nome);
        Task AddModelloAsync(Modello modello);
        Task<bool> ExistsByNameMAsync(string nome);
        Task AddColoreAsync(Colore colore);
        Task<bool> ExistsByNameColoreAsync(string nome);
        Task AddTagliaAsync(Taglia taglia);
        Task<bool> ExistsByNameTagliaAsync(string nome);
       
    }
}