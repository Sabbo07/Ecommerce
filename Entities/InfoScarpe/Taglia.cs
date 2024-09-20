using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Entities.InfoScarpe
{
    public class Taglia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(2)]
        public string Numero { get; set; }
        //proprieta di navigazione per le scarpe    
         public virtual ICollection<DettagliScarpa> DettagliScarpa { get; set; }

        public Taglia()
        {
            DettagliScarpa = new HashSet<DettagliScarpa>();
        }  
    }
}