using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Entities.InfoScarpe.DTO;
using Ecommerce.Repository.Shoes;
using Ecommerce.Repository.ShoesDTO;
using Ecommerce.Service.DTOService;

namespace Ecommerce.Service
{
    public class ScarpaDTOService : IScarpaDTOService
    {

        private readonly IScarpaRepository _scarpaRepository;
        private readonly IScarpaDTORepository _scarpaDTORepository;

        public ScarpaDTOService(IScarpaRepository scarpaRepository)
        {
            _scarpaRepository = scarpaRepository;
            _scarpaDTORepository = _scarpaDTORepository;
        }
        public async Task<ScarpaDTO> GetScarpaDtoByIdAsync(int id)
        {
            // Fetch the entity from the repository
            var scarpa = await _scarpaRepository.GetScarpaByIdAsync(id);

            if (scarpa == null) return null;

            // Map to DTO
            var scarpaDto = new ScarpaDTO
            {
                ModelloId = scarpa.ModelloId,
                NomeModello = scarpa.Modello.Nome,
                NomeBrand = scarpa.Brand.Nome,
                NomeCategoria = scarpa.Categoria.Nome,
                BrandId = scarpa.BrandId,
                CategoriaId = scarpa.CategoriaId,
                ColoreId = scarpa.ColoreId,
                Dettagli = scarpa.DettagliScarpe.Select(d => new DettagliScarpaDTO
                {
                    NumeroTaglia = d.Taglia.Numero,
                    TagliaId = d.TagliaId,
                    QtaTaglia = d.QtaTaglia,
                    Prezzo = d.Prezzo,
                    Sconto = d.Sconto
                }).ToList()
            };

            return scarpaDto;
        }
        public async Task<IEnumerable<ScarpaDTO>> GetAllScarpeDtoAsync()
        {
            // Fetch all the entities from the repository
            var scarpe = await _scarpaRepository.GetAllScarpeAsync();

            // Map to DTO
            var scarpeDto = scarpe.Select(s => new ScarpaDTO
            {
                ModelloId = s.ModelloId,
                NomeModello = s.Modello.Nome,
                NomeBrand = s.Brand.Nome,
                NomeCategoria = s.Categoria.Nome,
                BrandId = s.BrandId,
                CategoriaId = s.CategoriaId,
                ColoreId = s.ColoreId,
                Dettagli = s.DettagliScarpe.Select(d => new DettagliScarpaDTO
                {
                    NumeroTaglia = d.Taglia.Numero,
                    TagliaId = d.TagliaId,
                    QtaTaglia = d.QtaTaglia,
                    Prezzo = d.Prezzo,
                    Sconto = d.Sconto
                }).ToList()
            }).ToList();

            return scarpeDto;
        }
       public async Task<IEnumerable<ScarpaSearchResultDTO>> SearchScarpeByModelloNameAsync(ScarpaSearchDTO searchDto)
{
    var scarpe = await _scarpaDTORepository.SearchScarpeByModelloNameAsync(searchDto);

    // Map the necessary fields to the new DTO
    return scarpe.Select(s => new ScarpaSearchResultDTO
    {
        ModelloNome = s.Modello?.Nome,
        BrandNome = s.Brand?.Nome,
        ColoreNome = s.Colore?.Nome,
        NumeroTaglia = s.DettagliScarpe?.FirstOrDefault()?.Taglia?.Numero,
        CategoriaNome = s.Categoria?.Nome
    }).ToList();
}





    }
}