
using Ecommerce.Data;
using Ecommerce.Entities.InfoUtente;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.Listadeidesideri
{
    public class LDDRepository : ILDDRepository
    {
        private readonly EcommerceContext _context; // Replace with your actual DbContext

        public LDDRepository(EcommerceContext context)
        {
            _context = context;
        }

        public async Task<Whislist> GetListadeidesideriAsync(int clienteId)
        {
            return await _context.whislist.Include(w => w.listadesideri)
                                        .ThenInclude(ld => ld.Scarpa)
                                        .FirstOrDefaultAsync(w => w.ClienteId == clienteId);
        }

        public async Task AddListadeidesideriAsync(Whislist whislist)
        {
            await _context.whislist.AddAsync(whislist);
        }

        public async Task UpdateListadeidesideriAsync(Whislist whislist)
        {
            _context.whislist.Update(whislist);
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}