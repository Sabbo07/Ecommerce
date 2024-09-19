using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Entities.InfoScarpe
{
    public class Modello
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Nome { get; set; }
    }
}