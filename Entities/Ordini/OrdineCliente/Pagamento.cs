
using System.ComponentModel.DataAnnotations;


namespace Ecommerce.Entities.Ordini.OrdineCliente
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }
        [StringLength(16)]
        public string Tipo { get; set; }

        [StringLength(16)] 

        public string Nome { get; set; }
    }
}