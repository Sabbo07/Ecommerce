using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.InfoScarpe;

namespace Ecommerce.Entities.Ordini.OrdineMagazziniere
{
    public class DettaglioRifornimento
    {
        [Key]
        public int Id { get; set; }

        public int RifornimentoId { get; set; }

        [ForeignKey("RifornimentoId")]
        public virtual Rifornimento Rifornimento { get; set; }

        public int ScarpaId { get; set; }

        [ForeignKey("ScarpaId")]
        public virtual Scarpa Scarpa { get; set; }

        public int QuantitaPerTaglia { get; set; }

        public int ColoreId { get; set; }

        [ForeignKey("ColoreId")]
        public virtual Colore Colore { get; set; }

        public int TagliaId { get; set; }

        [ForeignKey("TagliaId")]
        public virtual Taglia Taglia { get; set; }
    }
}