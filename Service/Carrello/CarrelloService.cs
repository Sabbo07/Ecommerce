using Ecommerce.Entities.Carrello;
using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Service.Carrello;
using System.Linq;
using Ecommerce.Data;
using System.Threading.Tasks;

public class CarrelloService : ICarrelloService
{
    private readonly ICarrelloRepository _carrelloRepository;
    private readonly EcommerceContext _context;  // Replace with your actual DbContext

    public CarrelloService(ICarrelloRepository carrelloRepository, EcommerceContext context)
    {
        _carrelloRepository = carrelloRepository;
        _context = context;
    }

    public async Task AddScarpaToCartAsync(int clienteId, int scarpaId, int quantita)
    {
        // Find the cart associated with the customer (Cliente)
        var cart = await _carrelloRepository.GetCartByClienteIdAsync(clienteId);

        // If no cart exists for this customer, create one
        if (cart == null)
        {
            cart = new Cart
            {
                ClienteId = clienteId,
                CarrelloScarpe = new List<CarrelloScarpa>()
            };
            await _carrelloRepository.AddCarrelloAsync(cart);
        }

        // Find the shoe
        var scarpa = await _context.scarpa.FindAsync(scarpaId); // Assuming ScarpaRepo or DbContext handles this
        if (scarpa == null)
        {
            throw new Exception("Scarpa non trovata.");
        }

        // Check if the shoe is already in the cart
        var carrelloScarpa = cart.CarrelloScarpe.FirstOrDefault(cs => cs.ScarpaID == scarpaId);

        if (carrelloScarpa != null)
        {
            // Update quantity if the shoe is already in the cart
            carrelloScarpa.Quantita += quantita;
        }
        else
        {
            // Add the shoe to the cart
            cart.CarrelloScarpe.Add(new CarrelloScarpa
            {
                ScarpaID = scarpaId,
                Quantita = quantita
            });
        }

        // Update the cart and save changes
        await _carrelloRepository.UpdateCarrelloAsync(cart);
        await _carrelloRepository.SaveChangesAsync();
    }
}
