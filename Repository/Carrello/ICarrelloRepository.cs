using System.Threading.Tasks;
using Ecommerce.Entities.Carrello;

public interface ICarrelloRepository
{
    Task<Cart> GetCartByClienteIdAsync(int clienteId);
    Task AddCarrelloAsync(Cart cart);
    Task UpdateCarrelloAsync(Cart cart);
    Task SaveChangesAsync();
}