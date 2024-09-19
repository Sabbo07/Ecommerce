using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.Utenti;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ecommerce.Entities.Ordini.OrdineMagazziniere
{
    public class Rifornimento
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MagazziniereId")]
        public int MagazziniereId { get; set; }
        public Magazziniere Magazziniere { get; set; }
        [ForeignKey("NegozioId")]
        public int NegozioId { get; set; }
        public Negozio Negozio { get; set; }

        public virtual ICollection<DettaglioRifornimento> DettagliRifornimento { get; set; }

    }
}