using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Ordini.OrdineMagazziniere
{
    public class Negozio
    {
        [Key]
        public int Id { get; set; } 

        [StringLength(20)]
        public string Citta { get; set; }

        
    }
}