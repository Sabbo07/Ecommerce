using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Entities.InfoScarpe
{
    public class ScarpaColore
    {
        [Key]
        public int Id { get; set; }

        public int ScarpaId { get; set; }

        public Scarpa Scarpa { get; set; }

        public int ColoreId { get; set; }

        public Colore Colore { get; set; }
    }
}