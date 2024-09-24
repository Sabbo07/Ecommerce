using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities.InfoScarpe.DTO
{
    public class DettagliScarpaDTO
    {
        public int TagliaId { get; set; }
        public string NumeroTaglia { get; set; }
    public int QtaTaglia { get; set; }
    public double Prezzo { get; set; }
    public double Sconto { get; set; }
    }
}