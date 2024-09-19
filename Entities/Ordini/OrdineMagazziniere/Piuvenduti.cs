using System.ComponentModel.DataAnnotations;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Entities.Ordini.OrdineMagazziniere
{
    public class Piuvenduti
    {
        [Key]
        public int ID { get; set; } // Chiave primaria

        public virtual ICollection<Scarpa> Scarpe { get; set; }

        // Constructor to initialize the collection
        public Piuvenduti()
        {
            Scarpe = new HashSet<Scarpa>();
        }
    }
}