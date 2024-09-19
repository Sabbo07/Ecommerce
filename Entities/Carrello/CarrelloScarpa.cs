using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Entities.Carrello
{
    public class CarrelloScarpa
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("CarrelloId")]
        public int CarrelloID { get; set; }  // Foreign key verso Carrello
        [ForeignKey("ScarpaId")]
        public int ScarpaID { get; set; }    // Foreign key verso Scarpa
        public int Quantita { get; set; }    // Quantità di scarpe nel carrello

        // Navigazione verso l'entità Carrello
        public  Carrello Carrello { get; set; }

        // Navigazione verso l'entità Scarpa
        public  Scarpa Scarpa { get; set; }

        
    }
}