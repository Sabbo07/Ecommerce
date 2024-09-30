using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Entities.InfoUtente;


namespace Ecommerce.Entities.Listadesideri
{
    public class ListaDesideriScarpa
    {
        [Key, Column(Order = 0)]
        public int WhislistID { get; set; }  // Foreign key to Cart
        public virtual Whislist whislist { get; set; }  // Navigation property

        [Key, Column(Order = 1)]
        public int ScarpaID { get; set; }  // Foreign key to Scarpa
        public virtual Scarpa Scarpa { get; set; }  // Navigation property

        public int Quantita { get; set; }  // Quantity of shoes in the cart
    }
}