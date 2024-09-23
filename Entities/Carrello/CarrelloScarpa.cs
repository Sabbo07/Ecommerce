using Ecommerce.Entities.InfoScarpe;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entities.Carrello
{
    public class CarrelloScarpa
    {
        [Key, Column(Order = 0)]
        public int CartID { get; set; }  // Foreign key to Cart
        public virtual Cart Cart { get; set; }  // Navigation property

        [Key, Column(Order = 1)]
        public int ScarpaID { get; set; }  // Foreign key to Scarpa
        public virtual Scarpa Scarpa { get; set; }  // Navigation property

        public int Quantita { get; set; }  // Quantity of shoes in the cart
    }
}
