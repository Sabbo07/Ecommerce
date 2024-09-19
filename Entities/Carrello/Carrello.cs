

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.Utenti;
namespace Ecommerce.Entities.Carrello
{
    public class Carrello
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        
    }
}