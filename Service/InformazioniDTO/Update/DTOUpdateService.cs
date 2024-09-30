using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.InfoScarpe.DTO;
using Ecommerce.Entities.InfoScarpe.DTO.Update;
using Ecommerce.Repository.InformazioniDTO.Update;

namespace Ecommerce.Service.InformazioniDTO.Update
{
    public class DTOUpdateService : IDTOUpdateService
    {
        private readonly IDTOUpdateRepository _repository;
        public DTOUpdateService(IDTOUpdateRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> UpdateCategoriaAsync(CategoriaDTOUpdate dto)
        {
            // Retrieve the existing entity using the repository
            var categoria = await _repository.GetCategoriaByIdAsync(dto.Id);
            if (categoria == null)
            {
                return false;  // Categoria not found
            }

            // Map DTO fields to the entity (manually or with AutoMapper)
            categoria.Nome = dto.Nome;

            // Update and save changes via the repository
            await _repository.UpdateCategoriaAsync(categoria);
            await _repository.SaveAsync();

            return true;
        }
        public async Task<bool> UpdateModelloAsync(ModelloDTOUpdate dto)
        {
            // Retrieve the existing entity using the repository
            var modello = await _repository.GetModelloByIdAsync(dto.Id);
            if (modello == null)
            {
                return false;  // Categoria not found
            }

            // Map DTO fields to the entity (manually or with AutoMapper)
            modello.Nome = dto.Nome;

            // Update and save changes via the repository
            await _repository.UpdateModelloAsync(modello);
            await _repository.SaveAsync();

            return true;
        }
        public async Task<bool> UpdateBrandAsync(BrandDTOUpdate dto)
        {
            // Retrieve the existing entity using the repository
            var brand = await _repository.GetBrandByIdAsync(dto.Id);
            if (brand == null)
            {
                return false;  // Categoria not found
            }

            // Map DTO fields to the entity (manually or with AutoMapper)
            brand.Nome = dto.Nome;

            // Update and save changes via the repository
            await _repository.UpdateBrandAsync(brand);
            await _repository.SaveAsync();

            return true;
        }
        public async Task<bool> UpdateColoreAsync(ColoreDTOUpdate dto)
        {
            // Retrieve the existing entity using the repository
            var colore = await _repository.GetBrandByIdAsync(dto.Id);
            if (colore == null)
            {
                return false;  // Categoria not found
            }

            // Map DTO fields to the entity (manually or with AutoMapper)
            colore.Nome = dto.Nome;

            // Update and save changes via the repository
            await _repository.UpdateBrandAsync(colore);
            await _repository.SaveAsync();

            return true;
        }
        public async Task<bool> UpdateTagliaAsync(TagliaDTOUpdate dto)
        {
            // Retrieve the existing entity using the repository
            var taglia = await _repository.GetTagliaByIdAsync(dto.Id);
            if (taglia == null)
            {
                return false;  // Categoria not found
            }

            // Map DTO fields to the entity (manually or with AutoMapper)
            taglia.Numero = dto.Nome;

            // Update and save changes via the repository
            await _repository.UpdateTagliaAsync(taglia);
            await _repository.SaveAsync();

            return true;
        }
    
    }
}