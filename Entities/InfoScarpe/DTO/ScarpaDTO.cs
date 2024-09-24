using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities.InfoScarpe.DTO
{
    public class ScarpaDTO
    {
        public int ModelloId { get; set; }
        public string NomeModello { get; set; }
    public int BrandId { get; set; }
    public  string NomeBrand { get; set; }
    public int CategoriaId { get; set; }
    public string NomeCategoria { get; set; }
    public int ColoreId { get; set; }
    public string NomeColore { get; set; }

    public string NumeroTaglia { get; set; }
    public List<DettagliScarpaDTO> Dettagli { get; set; }
    }
}