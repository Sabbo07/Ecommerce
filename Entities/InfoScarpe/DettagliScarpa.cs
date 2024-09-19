
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entities.InfoScarpe
{
    public class DettagliScarpa
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ScarpaId")]
        public int ScarpaId { get; set; }
        public Scarpa Scarpa { get; set; }
        [ForeignKey("TagliaId")]
        public int TagliaId { get; set; }
        public Taglia Taglia { get; set; }

        public int qtaTaglia { get; set; }

        public double Prezzo { get; set; }
        public double Sconto { get; set; }

    }
}