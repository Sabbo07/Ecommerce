using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.Carrello;
namespace Ecommerce.Entities.InfoScarpe
{
    public class Scarpa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ModelloId { get; set; }

        [ForeignKey("ModelloId")]
        public virtual Modello Modello { get; set; }

        public int BrandId { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }


        public int ColoreId { get; set; }

        [ForeignKey("ColoreId")]
        public virtual Colore Colore { get; set; }

        public virtual ICollection<CarrelloScarpa> CarrelloScarpe { get; set; }  // One-to-many: one shoe can be in many carts


        // proprieta di navigazione

        public virtual ICollection<DettagliScarpa> DettagliScarpe { get; set; } 
        public Scarpa()
        {
            DettagliScarpe = new HashSet<DettagliScarpa>();
        }


    }
}