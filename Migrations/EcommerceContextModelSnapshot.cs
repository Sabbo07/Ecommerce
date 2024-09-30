﻿// <auto-generated />
using System;
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    partial class EcommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.Entities.Carrello.CarrelloScarpa", b =>
                {
                    b.Property<int>("CartID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("ScarpaID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("Quantita")
                        .HasColumnType("int");

                    b.HasKey("CartID", "ScarpaID");

                    b.HasIndex("ScarpaID");

                    b.ToTable("carrelloscarpa");
                });

            modelBuilder.Entity("Ecommerce.Entities.Carrello.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("carrello");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("brand");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Colore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("colore");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.DettagliScarpa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Prezzo")
                        .HasColumnType("double");

                    b.Property<int>("QtaTaglia")
                        .HasColumnType("int");

                    b.Property<int>("ScarpaId")
                        .HasColumnType("int");

                    b.Property<double>("Sconto")
                        .HasColumnType("double");

                    b.Property<int>("TagliaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScarpaId");

                    b.HasIndex("TagliaId");

                    b.ToTable("dettagliscarpa");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Modello", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("modello");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Scarpa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("ColoreId")
                        .HasColumnType("int");

                    b.Property<int>("ModelloId")
                        .HasColumnType("int");

                    b.Property<int?>("PiuvendutiID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ColoreId");

                    b.HasIndex("ModelloId");

                    b.HasIndex("PiuvendutiID");

                    b.ToTable("scarpa");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Taglia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("taglia");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoUtente.CartaCredito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataScadenza")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NumeroCarta")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("carta");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoUtente.Whislist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("whislist");
                });

            modelBuilder.Entity("Ecommerce.Entities.Listadesideri.ListaDesideriScarpa", b =>
                {
                    b.Property<int>("WhislistID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("ScarpaID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("Quantita")
                        .HasColumnType("int");

                    b.HasKey("WhislistID", "ScarpaID");

                    b.HasIndex("ScarpaID");

                    b.ToTable("ListaDesideriScarpa");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineCliente.Ordine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<int>("Stato")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PagamentoId");

                    b.ToTable("ordine");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineCliente.OrdineScarpa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrdineId")
                        .HasColumnType("int");

                    b.Property<int>("Quantita")
                        .HasColumnType("int");

                    b.Property<int>("ScarpaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdineId");

                    b.HasIndex("ScarpaId");

                    b.ToTable("ordinescarpa");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineCliente.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.HasKey("Id");

                    b.ToTable("pagamento");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineMagazziniere.DettaglioRifornimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ColoreId")
                        .HasColumnType("int");

                    b.Property<int>("QuantitaPerTaglia")
                        .HasColumnType("int");

                    b.Property<int>("RifornimentoId")
                        .HasColumnType("int");

                    b.Property<int>("ScarpaId")
                        .HasColumnType("int");

                    b.Property<int>("TagliaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColoreId");

                    b.HasIndex("RifornimentoId");

                    b.HasIndex("ScarpaId");

                    b.HasIndex("TagliaId");

                    b.ToTable("dettagliorifornimento");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineMagazziniere.Negozio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Citta")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("negozio");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineMagazziniere.Piuvenduti", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("piuvenduti");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineMagazziniere.Rifornimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MagazziniereId")
                        .HasColumnType("int");

                    b.Property<int>("NegozioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MagazziniereId");

                    b.HasIndex("NegozioId");

                    b.ToTable("rifornimento");
                });

            modelBuilder.Entity("Ecommerce.Entities.Utenti.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Indirizzo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("Ecommerce.Entities.Utenti.Magazziniere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("magazziniere");
                });

            modelBuilder.Entity("Ecommerce.Entities.Carrello.CarrelloScarpa", b =>
                {
                    b.HasOne("Ecommerce.Entities.Carrello.Cart", "Cart")
                        .WithMany("CarrelloScarpe")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.InfoScarpe.Scarpa", "Scarpa")
                        .WithMany("CarrelloScarpe")
                        .HasForeignKey("ScarpaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Scarpa");
                });

            modelBuilder.Entity("Ecommerce.Entities.Carrello.Cart", b =>
                {
                    b.HasOne("Ecommerce.Entities.Utenti.Cliente", "Cliente")
                        .WithOne("Cart")
                        .HasForeignKey("Ecommerce.Entities.Carrello.Cart", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.DettagliScarpa", b =>
                {
                    b.HasOne("Ecommerce.Entities.InfoScarpe.Scarpa", "Scarpa")
                        .WithMany("DettagliScarpe")
                        .HasForeignKey("ScarpaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.InfoScarpe.Taglia", "Taglia")
                        .WithMany("DettagliScarpa")
                        .HasForeignKey("TagliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scarpa");

                    b.Navigation("Taglia");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Scarpa", b =>
                {
                    b.HasOne("Ecommerce.Entities.InfoScarpe.Brand", "Brand")
                        .WithMany("Scarpe")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.InfoScarpe.Categoria", "Categoria")
                        .WithMany("Scarpe")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.InfoScarpe.Colore", "Colore")
                        .WithMany("Scarpe")
                        .HasForeignKey("ColoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.InfoScarpe.Modello", "Modello")
                        .WithMany("Scarpe")
                        .HasForeignKey("ModelloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.Ordini.OrdineMagazziniere.Piuvenduti", null)
                        .WithMany("Scarpe")
                        .HasForeignKey("PiuvendutiID");

                    b.Navigation("Brand");

                    b.Navigation("Categoria");

                    b.Navigation("Colore");

                    b.Navigation("Modello");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoUtente.CartaCredito", b =>
                {
                    b.HasOne("Ecommerce.Entities.Utenti.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoUtente.Whislist", b =>
                {
                    b.HasOne("Ecommerce.Entities.Utenti.Cliente", "Cliente")
                        .WithOne("Whislist")
                        .HasForeignKey("Ecommerce.Entities.InfoUtente.Whislist", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Ecommerce.Entities.Listadesideri.ListaDesideriScarpa", b =>
                {
                    b.HasOne("Ecommerce.Entities.InfoScarpe.Scarpa", "Scarpa")
                        .WithMany("WhislistScarpe")
                        .HasForeignKey("ScarpaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.InfoUtente.Whislist", "whislist")
                        .WithMany("listadesideri")
                        .HasForeignKey("WhislistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scarpa");

                    b.Navigation("whislist");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineCliente.Ordine", b =>
                {
                    b.HasOne("Ecommerce.Entities.Utenti.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.Ordini.OrdineCliente.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineCliente.OrdineScarpa", b =>
                {
                    b.HasOne("Ecommerce.Entities.Ordini.OrdineCliente.Ordine", "Ordine")
                        .WithMany("OrdineScarpa")
                        .HasForeignKey("OrdineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.InfoScarpe.Scarpa", "Scarpa")
                        .WithMany()
                        .HasForeignKey("ScarpaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ordine");

                    b.Navigation("Scarpa");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineMagazziniere.DettaglioRifornimento", b =>
                {
                    b.HasOne("Ecommerce.Entities.InfoScarpe.Colore", "Colore")
                        .WithMany()
                        .HasForeignKey("ColoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.Ordini.OrdineMagazziniere.Rifornimento", "Rifornimento")
                        .WithMany("DettagliRifornimento")
                        .HasForeignKey("RifornimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.InfoScarpe.Scarpa", "Scarpa")
                        .WithMany()
                        .HasForeignKey("ScarpaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.InfoScarpe.Taglia", "Taglia")
                        .WithMany()
                        .HasForeignKey("TagliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colore");

                    b.Navigation("Rifornimento");

                    b.Navigation("Scarpa");

                    b.Navigation("Taglia");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineMagazziniere.Rifornimento", b =>
                {
                    b.HasOne("Ecommerce.Entities.Utenti.Magazziniere", "Magazziniere")
                        .WithMany()
                        .HasForeignKey("MagazziniereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Entities.Ordini.OrdineMagazziniere.Negozio", "Negozio")
                        .WithMany()
                        .HasForeignKey("NegozioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Magazziniere");

                    b.Navigation("Negozio");
                });

            modelBuilder.Entity("Ecommerce.Entities.Carrello.Cart", b =>
                {
                    b.Navigation("CarrelloScarpe");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Brand", b =>
                {
                    b.Navigation("Scarpe");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Categoria", b =>
                {
                    b.Navigation("Scarpe");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Colore", b =>
                {
                    b.Navigation("Scarpe");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Modello", b =>
                {
                    b.Navigation("Scarpe");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Scarpa", b =>
                {
                    b.Navigation("CarrelloScarpe");

                    b.Navigation("DettagliScarpe");

                    b.Navigation("WhislistScarpe");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoScarpe.Taglia", b =>
                {
                    b.Navigation("DettagliScarpa");
                });

            modelBuilder.Entity("Ecommerce.Entities.InfoUtente.Whislist", b =>
                {
                    b.Navigation("listadesideri");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineCliente.Ordine", b =>
                {
                    b.Navigation("OrdineScarpa");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineMagazziniere.Piuvenduti", b =>
                {
                    b.Navigation("Scarpe");
                });

            modelBuilder.Entity("Ecommerce.Entities.Ordini.OrdineMagazziniere.Rifornimento", b =>
                {
                    b.Navigation("DettagliRifornimento");
                });

            modelBuilder.Entity("Ecommerce.Entities.Utenti.Cliente", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Whislist")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
