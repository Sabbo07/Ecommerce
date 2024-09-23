using Ecommerce.Entities.Utenti;
public interface IMagazziniereService
    {
        void CreateMagazziniere(Magazziniere magazziniere);
        Magazziniere Login(string email, string password);
    }
