using Ecommerce.Entities.Carrello;
using System.ComponentModel.DataAnnotations;

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

        // One-to-One relationship with Cart
        public virtual Cart Cart { get; set; }
    }
}
