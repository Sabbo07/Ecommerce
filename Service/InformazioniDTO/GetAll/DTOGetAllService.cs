using Ecommerce.Entities.InfoScarpe.DTO.GetAll;
using Ecommerce.Repository.InformazioniDTO.GetAll;

namespace Ecommerce.Service.InformazioniDTO.GetAll
{
    public class DTOGetAllService : IDTOGetAllService
    {
        private readonly IDTOGetAllRepository _DTOGetAllRepository;
        public DTOGetAllService(IDTOGetAllRepository DTOGetAllRepository)
        {
            _DTOGetAllRepository = DTOGetAllRepository;
        }
        public async Task<IEnumerable<CategoriaDTOGetAll>> GetAllCategoriaAsync()
        {
            var categoria = await _DTOGetAllRepository.GetAllCategoriasAsync();

            // Manually map Categoria to CategoriaDto
            var categoriaDto = categoria.Select(c => new CategoriaDTOGetAll
            {
                Id = c.Id,
                Nome = c.Nome
            });

            return categoriaDto;
        }
        public async Task<IEnumerable<BrandDTOGetAll>> GetAllBrandAsync()
        {
            var brand = await _DTOGetAllRepository.GetAllBrandsAsync();

            // Manually map Brand to BrandDto
            var brandDto = brand.Select(b => new BrandDTOGetAll
            {
                Id = b.Id,
                Nome = b.Nome
            });

            return brandDto;
        }
        public async Task<IEnumerable<ModelloDTOGetAll>> GetAllModelloAsync()
        {
            var modello = await _DTOGetAllRepository.GetAllModelliAsync();

            // Manually map Modello to ModelloDto
            var modelloDto = modello.Select(m => new ModelloDTOGetAll
            {
                Id = m.Id,
                Nome = m.Nome
            });

            return modelloDto;
        }
        public async Task<IEnumerable<TagliaDTOGetAll>> GetAllTagliaAsync()
        {
            var taglia = await _DTOGetAllRepository.GetAllTaglieAsync();

            // Manually map Taglia to TagliaDto
            var tagliaDto = taglia.Select(t => new TagliaDTOGetAll
            {
                Id = t.Id,
                Numero = t.Numero
            });

            return tagliaDto;
        }
        public async Task<IEnumerable<ColoreDTOGetAll>> GetAllColoreAsync()
        {
            var colore = await _DTOGetAllRepository.GetAllColoriAsync();

            // Manually map Colore to ColoreDto
            var coloreDto = colore.Select(c => new ColoreDTOGetAll
            {
                Id = c.Id,
                Nome = c.Nome
            });

            return coloreDto;
        }
    }
}