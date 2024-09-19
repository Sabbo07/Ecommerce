

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Ecommerce.Entities.InfoScarpe;   
namespace Ecommerce.Entities.Ordini.OrdineCliente
{
    public class OrdineScarpa
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("OrdineId")]
        public int OrdineId { get; set; }

        [ForeignKey("ScarpaId")]
        public int ScarpaId { get; set; }
        public int Quantita { get; set; }

        // Navigation properties
        public virtual Ordine Ordine { get; set; }
        public virtual Scarpa Scarpa { get; set; }

        
    }
}