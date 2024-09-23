using Ecommerce.Entities.Utenti;
using Ecommerce.Repository.Warehouseman;    

namespace Ecommerce.Service.Warehouseman
{
    public class MagazziniereService : IMagazziniereService
    {
        private readonly IMagazziniereRepository _repository;

    public MagazziniereService(IMagazziniereRepository repository)
    {
        _repository = repository;
    }

    public void CreateMagazziniere(Magazziniere magazziniere)
    {
        // Add validation logic if needed
        _repository.Add(magazziniere);
    }
    public Magazziniere Login(string email, string password)
    {
        // Check if the user exists and the password is correct
        var magazziniere = _repository.GetByEmail(email);
        if (magazziniere != null && magazziniere.Password == password) // Use a secure method for password checking in production
        {
            return magazziniere;
        }

        return null; // Invalid credentials
    }

    
    }
}