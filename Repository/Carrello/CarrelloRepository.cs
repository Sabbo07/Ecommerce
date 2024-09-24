using Ecommerce.Entities.Carrello;
using Ecommerce.Data; // Adjust the namespace
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class CarrelloRepository : ICarrelloRepository
{
    private readonly EcommerceContext _context; // Replace with your actual DbContext

    public CarrelloRepository(EcommerceContext context)
    {
        _context = context;
    }

    public async Task<Cart> GetCartByClienteIdAsync(int clienteId)
    {
        return await _context.carrello.Include(c => c.CarrelloScarpe)
                                    .ThenInclude(cs => cs.Scarpa)
                                    .FirstOrDefaultAsync(c => c.ClienteId == clienteId);
    }

    public async Task AddCarrelloAsync(Cart cart)
    {
        await _context.carrello.AddAsync(cart);
    }

    public async Task UpdateCarrelloAsync(Cart cart)
    {
        _context.carrello.Update(cart);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
