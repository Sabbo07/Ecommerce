using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class Whislist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cognome = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Indirizzo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "colore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colore", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "magazziniere",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cognome = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_magazziniere", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "modello",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modello", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "negozio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Citta = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_negozio", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagamento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "piuvenduti",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_piuvenduti", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "taglia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taglia", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "carrello",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carrello", x => x.Id);
                    table.ForeignKey(
                        name: "FK_carrello_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "carta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroCarta = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataScadenza = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CVV = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_carta_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "whislist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_whislist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_whislist_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rifornimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MagazziniereId = table.Column<int>(type: "int", nullable: false),
                    NegozioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rifornimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rifornimento_magazziniere_MagazziniereId",
                        column: x => x.MagazziniereId,
                        principalTable: "magazziniere",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rifornimento_negozio_NegozioId",
                        column: x => x.NegozioId,
                        principalTable: "negozio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ordine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Stato = table.Column<int>(type: "int", nullable: false),
                    PagamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ordine_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordine_pagamento_PagamentoId",
                        column: x => x.PagamentoId,
                        principalTable: "pagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "scarpa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModelloId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ColoreId = table.Column<int>(type: "int", nullable: false),
                    PiuvendutiID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scarpa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_scarpa_brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scarpa_categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scarpa_colore_ColoreId",
                        column: x => x.ColoreId,
                        principalTable: "colore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scarpa_modello_ModelloId",
                        column: x => x.ModelloId,
                        principalTable: "modello",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scarpa_piuvenduti_PiuvendutiID",
                        column: x => x.PiuvendutiID,
                        principalTable: "piuvenduti",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "carrelloscarpa",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false),
                    ScarpaID = table.Column<int>(type: "int", nullable: false),
                    Quantita = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carrelloscarpa", x => new { x.CartID, x.ScarpaID });
                    table.ForeignKey(
                        name: "FK_carrelloscarpa_carrello_CartID",
                        column: x => x.CartID,
                        principalTable: "carrello",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_carrelloscarpa_scarpa_ScarpaID",
                        column: x => x.ScarpaID,
                        principalTable: "scarpa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dettagliorifornimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RifornimentoId = table.Column<int>(type: "int", nullable: false),
                    ScarpaId = table.Column<int>(type: "int", nullable: false),
                    QuantitaPerTaglia = table.Column<int>(type: "int", nullable: false),
                    ColoreId = table.Column<int>(type: "int", nullable: false),
                    TagliaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dettagliorifornimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dettagliorifornimento_colore_ColoreId",
                        column: x => x.ColoreId,
                        principalTable: "colore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dettagliorifornimento_rifornimento_RifornimentoId",
                        column: x => x.RifornimentoId,
                        principalTable: "rifornimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dettagliorifornimento_scarpa_ScarpaId",
                        column: x => x.ScarpaId,
                        principalTable: "scarpa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dettagliorifornimento_taglia_TagliaId",
                        column: x => x.TagliaId,
                        principalTable: "taglia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dettagliscarpa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ScarpaId = table.Column<int>(type: "int", nullable: false),
                    TagliaId = table.Column<int>(type: "int", nullable: false),
                    QtaTaglia = table.Column<int>(type: "int", nullable: false),
                    Prezzo = table.Column<double>(type: "double", nullable: false),
                    Sconto = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dettagliscarpa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dettagliscarpa_scarpa_ScarpaId",
                        column: x => x.ScarpaId,
                        principalTable: "scarpa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dettagliscarpa_taglia_TagliaId",
                        column: x => x.TagliaId,
                        principalTable: "taglia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ListaDesideriScarpa",
                columns: table => new
                {
                    WhislistID = table.Column<int>(type: "int", nullable: false),
                    ScarpaID = table.Column<int>(type: "int", nullable: false),
                    Quantita = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaDesideriScarpa", x => new { x.WhislistID, x.ScarpaID });
                    table.ForeignKey(
                        name: "FK_ListaDesideriScarpa_scarpa_ScarpaID",
                        column: x => x.ScarpaID,
                        principalTable: "scarpa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListaDesideriScarpa_whislist_WhislistID",
                        column: x => x.WhislistID,
                        principalTable: "whislist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ordinescarpa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrdineId = table.Column<int>(type: "int", nullable: false),
                    ScarpaId = table.Column<int>(type: "int", nullable: false),
                    Quantita = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordinescarpa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ordinescarpa_ordine_OrdineId",
                        column: x => x.OrdineId,
                        principalTable: "ordine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordinescarpa_scarpa_ScarpaId",
                        column: x => x.ScarpaId,
                        principalTable: "scarpa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_carrello_ClienteId",
                table: "carrello",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_carrelloscarpa_ScarpaID",
                table: "carrelloscarpa",
                column: "ScarpaID");

            migrationBuilder.CreateIndex(
                name: "IX_carta_ClienteId",
                table: "carta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_dettagliorifornimento_ColoreId",
                table: "dettagliorifornimento",
                column: "ColoreId");

            migrationBuilder.CreateIndex(
                name: "IX_dettagliorifornimento_RifornimentoId",
                table: "dettagliorifornimento",
                column: "RifornimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_dettagliorifornimento_ScarpaId",
                table: "dettagliorifornimento",
                column: "ScarpaId");

            migrationBuilder.CreateIndex(
                name: "IX_dettagliorifornimento_TagliaId",
                table: "dettagliorifornimento",
                column: "TagliaId");

            migrationBuilder.CreateIndex(
                name: "IX_dettagliscarpa_ScarpaId",
                table: "dettagliscarpa",
                column: "ScarpaId");

            migrationBuilder.CreateIndex(
                name: "IX_dettagliscarpa_TagliaId",
                table: "dettagliscarpa",
                column: "TagliaId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaDesideriScarpa_ScarpaID",
                table: "ListaDesideriScarpa",
                column: "ScarpaID");

            migrationBuilder.CreateIndex(
                name: "IX_ordine_ClienteId",
                table: "ordine",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ordine_PagamentoId",
                table: "ordine",
                column: "PagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ordinescarpa_OrdineId",
                table: "ordinescarpa",
                column: "OrdineId");

            migrationBuilder.CreateIndex(
                name: "IX_ordinescarpa_ScarpaId",
                table: "ordinescarpa",
                column: "ScarpaId");

            migrationBuilder.CreateIndex(
                name: "IX_rifornimento_MagazziniereId",
                table: "rifornimento",
                column: "MagazziniereId");

            migrationBuilder.CreateIndex(
                name: "IX_rifornimento_NegozioId",
                table: "rifornimento",
                column: "NegozioId");

            migrationBuilder.CreateIndex(
                name: "IX_scarpa_BrandId",
                table: "scarpa",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_scarpa_CategoriaId",
                table: "scarpa",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_scarpa_ColoreId",
                table: "scarpa",
                column: "ColoreId");

            migrationBuilder.CreateIndex(
                name: "IX_scarpa_ModelloId",
                table: "scarpa",
                column: "ModelloId");

            migrationBuilder.CreateIndex(
                name: "IX_scarpa_PiuvendutiID",
                table: "scarpa",
                column: "PiuvendutiID");

            migrationBuilder.CreateIndex(
                name: "IX_whislist_ClienteId",
                table: "whislist",
                column: "ClienteId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carrelloscarpa");

            migrationBuilder.DropTable(
                name: "carta");

            migrationBuilder.DropTable(
                name: "dettagliorifornimento");

            migrationBuilder.DropTable(
                name: "dettagliscarpa");

            migrationBuilder.DropTable(
                name: "ListaDesideriScarpa");

            migrationBuilder.DropTable(
                name: "ordinescarpa");

            migrationBuilder.DropTable(
                name: "carrello");

            migrationBuilder.DropTable(
                name: "rifornimento");

            migrationBuilder.DropTable(
                name: "taglia");

            migrationBuilder.DropTable(
                name: "whislist");

            migrationBuilder.DropTable(
                name: "ordine");

            migrationBuilder.DropTable(
                name: "scarpa");

            migrationBuilder.DropTable(
                name: "magazziniere");

            migrationBuilder.DropTable(
                name: "negozio");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "pagamento");

            migrationBuilder.DropTable(
                name: "brand");

            migrationBuilder.DropTable(
                name: "categoria");

            migrationBuilder.DropTable(
                name: "colore");

            migrationBuilder.DropTable(
                name: "modello");

            migrationBuilder.DropTable(
                name: "piuvenduti");
        }
    }
}
