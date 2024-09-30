using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Entities.InfoScarpe;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.InformazioniDTO.GetAll
{
    public class DTOGetAllRepository : IDTOGetAllRepository
    {
        private readonly EcommerceContext _context;
        public DTOGetAllRepository(EcommerceContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Categoria>> GetAllCategoriasAsync()
        {
            return await _context.categoria.ToListAsync();
        }
        public async Task<IEnumerable<Brand>> GetAllBrandsAsync()
        {
            return await _context.brand.ToListAsync();
        }
        public async Task<IEnumerable<Modello>> GetAllModelliAsync()
        {
            return await _context.modello.ToListAsync();
        }
        public async Task<IEnumerable<Taglia>> GetAllTaglieAsync()
        {
            return await _context.taglia.ToListAsync();
        }
        public async Task<IEnumerable<Colore>> GetAllColoriAsync()
        {
            return await _context.colore.ToListAsync(); // Return all the colors
        }

    }
}