using Ecommerce.Entities.Carrello;
using Ecommerce.Entities.InfoScarpe;
using Ecommerce.Entities.InfoUtente;
using Ecommerce.Entities.Ordini.OrdineCliente;
using Ecommerce.Entities.Ordini.OrdineMagazziniere;
using Ecommerce.Entities.Utenti;
using Microsoft.EntityFrameworkCore;
namespace Ecommerce.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }

        public DbSet<Carrello> carrello { get; set; }
        public DbSet<CarrelloScarpa> carrelloscarpa { get; set; }
        public DbSet<CartaCredito> carta { get; set; }
        public DbSet<Whislist> whislist { get; set; }
        public DbSet<Brand> brand { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Colore> colore { get; set; }
        public DbSet<DettagliScarpa> dettagliscarpa { get; set; }
        public DbSet<Modello> modello { get; set; }
        public DbSet<Scarpa> scarpa { get; set; }
        public DbSet<Taglia> taglia { get; set; }
        public DbSet<Ordine> ordine { get; set; }
        public DbSet<OrdineScarpa> ordinescarpa { get; set; }
        public DbSet<Pagamento> pagamento { get; set; }
        public DbSet<DettaglioRifornimento> dettagliorifornimento { get; set; }
        public DbSet<Negozio> negozio { get; set; }
        public DbSet<Piuvenduti> piuvenduti { get; set; }
        public DbSet<Rifornimento> rifornimento { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Magazziniere> magazziniere { get; set; }

        // Configurazione per non caricare dati superflui
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configurazione delle relazioni tra le entità

            //Configurazione della scarpa

            modelBuilder.Entity<Scarpa>()
                .HasOne(s => s.Brand)   // una scarpa ha un brand
                .WithMany(b => b.Scarpe) // un brand ha molte scarpe
                .HasForeignKey(s => s.BrandId); // la scarpa ha una chiave esterna BrandId
            
            modelBuilder.Entity<Scarpa>()
                .HasOne(s => s.Modello)  // una scarpa ha un modello
                .WithMany(m => m.Scarpe) // un modello ha molte scarpe
                .HasForeignKey(s => s.ModelloId); // la scarpa ha una chiave esterna ModelloId

            modelBuilder.Entity<Scarpa>()
                .HasOne(s => s.Categoria) // una scarpa ha una categoria
                .WithMany(c => c.Scarpe) // una categoria ha molte scarpe
                .HasForeignKey(s => s.CategoriaId); // la scarpa ha una chiave esterna CategoriaId

            modelBuilder.Entity<Scarpa>()
                .HasOne(s => s.Colore) // una scarpa ha un colore
                .WithMany(c => c.Scarpe) // un colore ha molte scarpe
                .HasForeignKey(s => s.ColoreId); // la scarpa ha una chiave esterna ColoreId

            modelBuilder.Entity<Scarpa>()
                .HasMany(s => s.DettagliScarpe) // una scarpa ha molti dettagli scarpe
                .WithOne(d => d.Scarpa) // un dettaglio scarpa ha una scarpa
                .HasForeignKey(s => s.ScarpaId); // la scarpa ha una chiave esterna ScarpaId
             
             //Configurazione specifica della taglia

              modelBuilder.Entity<DettagliScarpa>()
                .HasOne(ds => ds.Taglia)
                .WithMany(t => t.DettagliScarpa)
                .HasForeignKey(ds => ds.TagliaId);
        }







    }
}