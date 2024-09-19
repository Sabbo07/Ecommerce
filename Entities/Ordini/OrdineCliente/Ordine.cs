
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.Utenti;
namespace Ecommerce.Entities.Ordini.OrdineCliente
{
    public class Ordine
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("OrdineScarpaId")]
        public int OrdineScarpaId { get; set; }
        public virtual ICollection<OrdineScarpa> OrdineScarpa { get; set; }

        public StatoOrdine Stato { get; set; }

        [ForeignKey("PagamentoId")]

        public int PagamentoId { get; set; }
        public Pagamento Pagamento { get; set; }
        public Ordine()
        {
            OrdineScarpa = new HashSet<OrdineScarpa>();
        }
    }
}