using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Entities.Utenti;
using System.Collections.Generic;

namespace Ecommerce.Entities.Ordini.OrdineCliente
{
    public class Ordine
    {
        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<OrdineScarpa> OrdineScarpa { get; set; }

        public StatoOrdine Stato { get; set; }

        public int PagamentoId { get; set; }

        [ForeignKey("PagamentoId")]
        public virtual Pagamento Pagamento { get; set; }

        public Ordine()
        {
            OrdineScarpa = new HashSet<OrdineScarpa>();
        }
    }
}