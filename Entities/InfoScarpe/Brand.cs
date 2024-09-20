using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities.InfoScarpe
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Nome { get; set; }


        //proprieta di navigazione per le scarpe
        public virtual ICollection<Scarpa> Scarpe { get; set; }

        //costruttore di Scarpe per evitare errori di riferenza
        public Brand()
        {
            Scarpe = new HashSet<Scarpa>();
        }
    }
}