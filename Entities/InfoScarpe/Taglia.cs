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
    }
}