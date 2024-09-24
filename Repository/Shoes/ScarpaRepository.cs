using Ecommerce.Data;
using Ecommerce.Entities.InfoScarpe;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.Shoes
{
public class ScarpaRepository : IScarpaRepository
{
    private readonly EcommerceContext _context;

    public ScarpaRepository(EcommerceContext context)
    {
        _context = context;
    }

    // Get all shoes with related data (eager loading)
    public async Task<IEnumerable<Scarpa>> GetAllScarpeAsync()
    {
        return await _context.scarpa
            .Include(s => s.Brand)
            .Include(s => s.Modello)
            .Include(s => s.Categoria)
            .Include(s => s.Colore)
            .Include(s => s.DettagliScarpe)
            .ToListAsync();
    }

    // Get shoe by ID with related data
    public async Task<Scarpa> GetScarpaByIdAsync(int id)
    {
        return await _context.scarpa
            .Include(s => s.Brand)
            .Include(s => s.Modello)
            .Include(s => s.Categoria)
            .Include(s => s.Colore)
            .Include(s => s.DettagliScarpe)
            .FirstOrDefaultAsync(s => s.Id == id);
    }

    // Add a new shoe
    public async Task<Scarpa> AddScarpaAsync(Scarpa scarpa)
    {
        _context.scarpa.Add(scarpa);
        await _context.SaveChangesAsync();

        return scarpa;
    }

    // Update an existing shoe
    public async Task<Scarpa> UpdateScarpaAsync(Scarpa scarpa)
    {
        _context.scarpa.Update(scarpa);
        await _context.SaveChangesAsync();

        return scarpa;
    }

    // Delete a shoe
    public async Task DeleteScarpaAsync(int id)
    {
        var scarpa = await _context.scarpa.FindAsync(id);
        if (scarpa != null)
        {
            _context.scarpa.Remove(scarpa);
            await _context.SaveChangesAsync();
        }
    }

     public void AddScarpa(Scarpa scarpa)
    {
        _context.Set<Scarpa>().Add(scarpa);
        _context.SaveChanges();
    }
    public List<Scarpa> GetByModelloNome(string modelloNome)
{
    if (string.IsNullOrWhiteSpace(modelloNome))
    {
        return new List<Scarpa>(); // Restituisci una lista vuota se il nome del modello è null o vuoto
    }

    var scarpe = _context.scarpa
        .Include(s => s.Modello)
        .Include(s => s.Categoria)
        .Include(s => s.Brand)
        .Include(s => s.Colore)
        .Where(s => s.Modello.Nome.ToLower().Contains(modelloNome.ToLower()))
        .ToList();

    
    return scarpe;
}
public async Task<List<Scarpa>> GetByModelloNomeAsync(string modelloNome)
{
    if (string.IsNullOrWhiteSpace(modelloNome))
    {
        return new List<Scarpa>(); // Return an empty list if the model name is null or empty
    }

    var scarpe = await _context.scarpa
        .Include(s => s.Modello)
        .Include(s => s.Categoria)
        .Include(s => s.Brand)
        .Include(s => s.Colore)
        .Where(s => s.Modello.Nome.ToLower().Contains(modelloNome.ToLower()))
        .ToListAsync();

    return scarpe;
}
    
}
}