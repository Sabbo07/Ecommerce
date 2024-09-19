
using System.ComponentModel.DataAnnotations;

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