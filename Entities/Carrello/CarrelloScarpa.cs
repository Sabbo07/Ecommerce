using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Entities.Carrello
{
    public class CarrelloScarpa
    {
        [Key]
        public int ID { get; set; }

        public int CarrelloID { get; set; }  // Foreign key verso Carrello
        public int ScarpaID { get; set; }    // Foreign key verso Scarpa
        public int Quantita { get; set; }    // Quantità di scarpe nel carrello

        // Navigazione verso l'entità Carrello
        [ForeignKey("CarrelloID")]
        public virtual Carrello Carrello { get; set; }

        // Navigazione verso l'entità Scarpa
        [ForeignKey("ScarpaID")]
        public virtual Scarpa Scarpa { get; set; }
    }
}