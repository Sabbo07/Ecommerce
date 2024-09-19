using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Entities.Ordini.OrdineCliente
{
    public class OrdineScarpa
    {
        [Key]
        public int Id { get; set; }

        public int OrdineId { get; set; }

        public int ScarpaId { get; set; }

        public int Quantita { get; set; }

        // Navigation properties
        [ForeignKey("OrdineId")]
        public virtual Ordine Ordine { get; set; }

        [ForeignKey("ScarpaId")]
        public virtual Scarpa Scarpa { get; set; }
    }
}