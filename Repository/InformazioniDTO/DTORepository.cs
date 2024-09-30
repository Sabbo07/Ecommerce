
using Ecommerce.Data;
using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Entities.InfoScarpe.DTO;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.InformazioniDTO
{
    public class DTORepository : IDTORepository
    {
        private readonly EcommerceContext _context;

        public DTORepository(EcommerceContext context)
        {
            _context = context;
        }

        public async Task AddCategoriaAsync(Categoria categoria)
        {
            _context.categoria.Add(categoria);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ExistsByNameCAsync(string nome)
        {
            // Check if a category with the same name already exists
            return await _context.categoria.AnyAsync(c => c.Nome == nome);
        }
        public async Task AddBrandAsync(Brand brand)
        {
            _context.brand.Add(brand);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ExistsByNameBAsync(string nome)
        {
            // Check if a brand with the same name already exists
            return await _context.brand.AnyAsync(b => b.Nome == nome);
        }
        public async Task AddModelloAsync(Modello modello)
        {
            _context.modello.Add(modello);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ExistsByNameMAsync(string nome)
        {
            // Check if a model with the same name already exists
            return await _context.modello.AnyAsync(m => m.Nome == nome);
        }
        public async Task AddColoreAsync(Colore colore)
        {
            _context.colore.Add(colore);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ExistsByNameColoreAsync(string nome)
        {
            // Check if a color with the same name already exists
            return await _context.colore.AnyAsync(c => c.Nome == nome);
        }
        public async Task AddTagliaAsync(Taglia taglia)
        {
            _context.taglia.Add(taglia);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> ExistsByNameTagliaAsync(string numero)
        {
            // Check if a size with the same name already exists
            return await _context.taglia.AnyAsync(t => t.Numero == numero);
        }
    }
}