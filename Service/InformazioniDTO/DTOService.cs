
using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Entities.InfoScarpe.DTO;
using Ecommerce.Repository.InformazioniDTO;

namespace Ecommerce.Service.InformazioniDTO
{
    public class DTOService : IDTOService
    {
        private readonly IDTORepository _DTORepository;

    public DTOService(IDTORepository DTORepository)
    {
        _DTORepository = DTORepository;
    }

    public async Task AddCategoriaAsync(CategoriaDTO categoriaDto)
    {
        // Business logic: for example, validate that the category name is unique
        if (await _DTORepository.ExistsByNameCAsync(categoriaDto.Nome))
        {
            throw new Exception("Categoria with the same name already exists.");
        }

        // Map the CategoriaDTO to the Categoria entity
        var categoria = new Categoria
        {
            Nome = categoriaDto.Nome
        };

        // Call repository to add the new category
        await _DTORepository.AddCategoriaAsync(categoria);
    }
    public async Task addBrandAsync(BrandDTO brandDto)
    {
        // Business logic: for example, validate that the brand name is unique
        if (await _DTORepository.ExistsByNameBAsync(brandDto.Nome))
        {
            throw new Exception("Brand with the same name already exists.");
        }

        // Map the BrandDTO to the Brand entity
        var brand = new Brand
        {
            Nome = brandDto.Nome
        };

        // Call repository to add the new brand
        await _DTORepository.AddBrandAsync(brand);
    }
    public async Task addModelloAsync(ModelloDTO modelloDTO)
    {
        // Business logic: for example, validate that the model name is unique
        if (await _DTORepository.ExistsByNameMAsync(modelloDTO.Nome))
        {
            throw new Exception("Modello with the same name already exists.");
        }

        // Map the ModelloDTO to the Modello entity
        var modello = new Modello
        {
            Nome = modelloDTO.Nome
        };

        // Call repository to add the new model
        await _DTORepository.AddModelloAsync(modello);
    }
    public async Task addColoreAsync(ColoreDTO coloreDTO)
    {
        // Business logic: for example, validate that the color name is unique
        if (await _DTORepository.ExistsByNameColoreAsync(coloreDTO.Nome))
        {
            throw new Exception("Colore with the same name already exists.");
        }

        // Map the ColoreDTO to the Colore entity
        var colore = new Colore
        {
            Nome = coloreDTO.Nome
        };

        // Call repository to add the new color
        await _DTORepository.AddColoreAsync(colore);
}
    public async Task addTagliaAsync(TagliaDTO tagliaDTO)
    {
        // Business logic: for example, validate that the taglia name is unique
        if (await _DTORepository.ExistsByNameTagliaAsync(tagliaDTO.Numero))
        {
            throw new Exception("Taglia with the same name already exists.");
        }
        // Map the TagliaDTO to the Taglia entity
        var taglia = new Taglia
        {
            Numero = tagliaDTO.Numero
        };
        await _DTORepository.AddTagliaAsync(taglia);
    }
    


}
}