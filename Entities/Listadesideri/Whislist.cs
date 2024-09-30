using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.Utenti;
using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Entities.Listadesideri;

namespace Ecommerce.Entities.InfoUtente
{
    public class Whislist
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        // One-to-One relationship with Cliente
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        // One-to-Many relationship with CarrelloScarpa (cart items)
        public virtual ICollection<ListaDesideriScarpa> listadesideri { get; set; }  // List of shoes in the cart
    }
}