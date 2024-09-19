using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entities.InfoScarpe
{
    public class ScarpaColore
    {
        [Key]
        public int Id { get; set; }

        public int ScarpaId { get; set; }

        [ForeignKey("ScarpaId")]
        public virtual Scarpa Scarpa { get; set; }

        public int ColoreId { get; set; }

        [ForeignKey("ColoreId")]
        public virtual Colore Colore { get; set; }
    }
}