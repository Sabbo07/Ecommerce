using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.Utenti;

namespace Ecommerce.Entities.InfoUtente
{
    public class CartaCredito
    {
        [Key]
        public int Id { get; set; }

        [StringLength(16)]
        public string NumeroCarta { get; set; }

        public DateTime DataScadenza { get; set; }

        [StringLength(3)]
        public string CVV { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
    }
}