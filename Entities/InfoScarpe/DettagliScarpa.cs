using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entities.InfoScarpe
{
    public class DettagliScarpa
    {
        [Key]
        public int Id { get; set; }

        public int ScarpaId { get; set; }
        public int TagliaId { get; set; }

        [ForeignKey("ScarpaId")]
        public virtual Scarpa Scarpa { get; set; }

        [ForeignKey("TagliaId")]
        public virtual Taglia Taglia { get; set; }

        public int QtaTaglia { get; set; }

        public double Prezzo { get; set; }
        public double Sconto { get; set; }

        
    }
}