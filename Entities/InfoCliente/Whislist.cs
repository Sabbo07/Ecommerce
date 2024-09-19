using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.Utenti;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Entities.InfoUtente
{
    public class Whislist
    {
        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public int ScarpaId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("ScarpaId")]
        public virtual Scarpa Scarpa { get; set; }
    }
}