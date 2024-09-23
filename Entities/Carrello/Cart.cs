using Ecommerce.Entities.Utenti;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities.Carrello
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        // One-to-One relationship with Cliente
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        // One-to-Many relationship with CarrelloScarpa (cart items)
        public virtual ICollection<CarrelloScarpa> CarrelloScarpe { get; set; }  // List of shoes in the cart
    }
}
