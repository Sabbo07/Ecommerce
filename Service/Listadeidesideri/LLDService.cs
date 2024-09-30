using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Entities.InfoUtente;
using Ecommerce.Entities.Listadesideri;
using Ecommerce.Repository.Listadeidesideri;

namespace Ecommerce.Service.Listadeidesideri
{
    public class LLDService : ILLDService
    {
        private readonly ILDDRepository _lldRepository;
        private readonly EcommerceContext _context;


    public LLDService(ILDDRepository lldRepository, EcommerceContext context)
    {
        _lldRepository = lldRepository;
        _context = context;
    }
    public async Task AddScarpaToWishlistAsync(int clienteId, int scarpaId, int quantita)
    {
        // Find the wishlist associated with the customer (Cliente)
        var wishlist = await _lldRepository.GetListadeidesideriAsync(clienteId);

        // If no wishlist exists for this customer, create one
        if (wishlist == null)
        {
            wishlist = new Whislist
            {
                ClienteId = clienteId,
                Id = clienteId,
                listadesideri = new List<ListaDesideriScarpa>()
            };
            
            await _lldRepository.AddListadeidesideriAsync(wishlist);
            await _lldRepository.SaveChangesAsync();
        }
        _context.whislist.Update(wishlist);
        // Find the shoe
        var scarpa = await _context.scarpa.FindAsync(scarpaId); // Assuming ScarpaRepo or DbContext handles this
        if (scarpa == null)
        {
            throw new Exception("Scarpa non trovata.");
        }

        // Check if the shoe is already in the wishlist
        var listadesideriScarpa = wishlist.listadesideri.FirstOrDefault(ld => ld.ScarpaID == scarpaId);
        if (listadesideriScarpa != null)
        {
            _context.listadesideriscarpa.Update(listadesideriScarpa);  // Only update if the item already exists
        }
        if (listadesideriScarpa != null)
        {
            // Update quantity if the shoe is already in the wishlist
            listadesideriScarpa.Quantita += quantita;
        }
        else
        {
            // Add the shoe to the wishlist
            wishlist.listadesideri.Add(new ListaDesideriScarpa
            {
                WhislistID = clienteId,
                ScarpaID = scarpaId,
                Quantita = quantita
            });
        }
        await _lldRepository.UpdateListadeidesideriAsync(wishlist);
        await _lldRepository.SaveChangesAsync();
}
    }
}