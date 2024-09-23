using Ecommerce.Entities.Utenti;
namespace Ecommerce.Repository.Warehouseman
{
    public interface IMagazziniereRepository
    {
        
            void Add(Magazziniere magazziniere);
            Magazziniere GetByEmail(string email);
    }
}