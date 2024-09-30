using Ecommerce.Data;
using Ecommerce.Entities.InfoScarpe;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.InformazioniDTO.Update
{
    public class DTOUpdateRepository : IDTOUpdateRepository
    {
        private readonly EcommerceContext _context;
        public DTOUpdateRepository(EcommerceContext context)
        {
            _context = context;
        }
        public async Task<Categoria> GetCategoriaByIdAsync(int id)
        {
            return await _context.categoria.FindAsync(id);  // Fetch categoria by Id
        }

        public async Task UpdateCategoriaAsync(Categoria categoria)
        {
            _context.categoria.Update(categoria);           // Update categoria entity
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();               // Save changes to the database
        }
        public async Task<Modello> GetModelloByIdAsync(int id)
        {
            return await _context.modello.FindAsync(id);  // Fetch categoria by Id
        }

        public async Task UpdateModelloAsync(Modello modello)
        {
            _context.modello.Update(modello);           // Update categoria entity
        }
        public async Task<Brand> GetBrandByIdAsync(int id)
        {
            return await _context.brand.FindAsync(id);  // Fetch categoria by Id
        }

        public async Task UpdateBrandAsync(Brand brand)
        {
            _context.brand.Update(brand);           // Update categoria entity
        }
        public async Task<Colore> GetColoreByIdAsync(int id)
        {
            return await _context.colore.FindAsync(id);  // Fetch categoria by Id
        }

        public async Task UpdateColoreAsync(Colore colore)
        {
            _context.colore.Update(colore);           // Update categoria entity
        }
        public async Task<Taglia> GetTagliaByIdAsync(int id)
        {
            return await _context.taglia.FindAsync(id);  // Fetch categoria by Id
        }

        public async Task UpdateTagliaAsync(Taglia taglia)
        {
            _context.taglia.Update(taglia);           // Update categoria entity
        }
        

    }
}