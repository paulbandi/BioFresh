using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BioFresh.Migrations
{
    public partial class Comenzi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comanda",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimpDeLivrare = table.Column<int>(type: "int", nullable: false),
                    DateDeContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PretTotal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comanda", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Livrare",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RidicareComanda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LivrareComanda = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livrare", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Livrata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preparata = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comanda");

            migrationBuilder.DropTable(
                name: "Livrare");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
