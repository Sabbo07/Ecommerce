using Ecommerce.Entities.Carrello;
using Ecommerce.Entities.Listadesideri;
using Ecommerce.Entities.InfoUtente;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Ecommerce.Entities.Utenti
{
    public class Cliente
    {
        [JsonIgnore]
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
        
        [JsonIgnore]
        public virtual Cart Cart { get; set; }

        [JsonIgnore]
        public virtual Whislist Whislist {get; set;}
 }
}
