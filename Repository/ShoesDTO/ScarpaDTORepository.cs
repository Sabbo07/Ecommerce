using Ecommerce.Data;
using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Entities.InfoScarpe.DTO;
using Ecommerce.Repository.Shoes;
using Microsoft.EntityFrameworkCore;
namespace Ecommerce.Repository.ShoesDTO
{
    public class ScarpaDTORepository : IScarpaDTORepository
    {
        private readonly EcommerceContext _context;
        private readonly IScarpaRepository _scarpaRepository;

    public ScarpaDTORepository(EcommerceContext context)
    {
        _context = context;
        _scarpaRepository = _scarpaRepository;
    }

    public async Task<IEnumerable<Scarpa>> SearchScarpeByModelloNameAsync(ScarpaSearchDTO searchDto)
    {
        if (string.IsNullOrWhiteSpace(searchDto.ModelloName))
        {
            throw new ArgumentException("Modello name cannot be empty."); // Handle invalid input
        }

        return await _context.scarpa
            .Include(s => s.Modello) // Include the Modello related data
            .Where(s => s.Modello != null && s.Modello.Nome.Contains(searchDto.ModelloName)) // Check for null
            .ToListAsync();
    }
    public async Task<List<Scarpa>> GetByModelloNomeAsync(string modelloNome)
{
    return await _scarpaRepository.GetByModelloNomeAsync(modelloNome);
}
}




    }
