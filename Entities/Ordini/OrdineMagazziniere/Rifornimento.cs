using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.Utenti;

namespace Ecommerce.Entities.Ordini.OrdineMagazziniere
{
    public class Rifornimento
    {
        [Key]
        public int Id { get; set; }

        public int MagazziniereId { get; set; }

        [ForeignKey("MagazziniereId")]
        public virtual Magazziniere Magazziniere { get; set; }

        public int NegozioId { get; set; }

        [ForeignKey("NegozioId")]
        public virtual Negozio Negozio { get; set; }

        public virtual ICollection<DettaglioRifornimento> DettagliRifornimento { get; set; }

        // Constructor to initialize the collection
        public Rifornimento()
        {
            DettagliRifornimento = new HashSet<DettaglioRifornimento>();
        }
    }
}