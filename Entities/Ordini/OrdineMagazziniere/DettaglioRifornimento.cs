using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Entities.Ordini.OrdineMagazziniere
{
    public class DettaglioRifornimento
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RifornimentoId")]
        public int RifornimentoId { get; set; }

        public Rifornimento Rifornimento { get; set; }

        [ForeignKey("ScarpaId")]
        public int ScarpaId { get; set; }
        public Scarpa Scarpa { get; set; }

        public int Quantitapertaglia { get; set; }

        public int ColoreId { get; set; }
        public Colore Colore { get; set; }

        public int TagliaId { get; set; }
        public Taglia Taglia { get; set; }
        
    }
}