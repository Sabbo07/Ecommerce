using System.ComponentModel.DataAnnotations;
using Ecommerce.Entities.Ordini.OrdineCliente;
namespace Ecommerce.Entities.Utenti
{
    public class Cliente
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Nome { get; set; }
        [Required]
        [StringLength(15)]
        public string Cognome { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Indirizzo { get; set; }

        // Collection of Ordini to represent the orders made by the Cliente
        public virtual ICollection<Ordine> Ordini { get; set; }

        // Constructor to initialize the collection
        public Cliente()
        {
            Ordini = new HashSet<Ordine>();
        }
    }
}