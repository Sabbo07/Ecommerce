using Ecommerce.Entities.Utenti;
using Ecommerce.Data;
namespace Ecommerce.Repository.Warehouseman
{
    public class MagazziniereRepository : IMagazziniereRepository
    {
        private readonly EcommerceContext _context;

    public MagazziniereRepository(EcommerceContext context)
    {
        _context = context;
    }

    public void Add(Magazziniere magazziniere)
    {
        _context.magazziniere.Add(magazziniere);
        _context.SaveChanges();
    }

    public Magazziniere GetByEmail(string email)
    {
        return _context.magazziniere.SingleOrDefault(m => m.Email == email);
    }


    }
}