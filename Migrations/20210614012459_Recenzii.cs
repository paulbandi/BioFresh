using Microsoft.EntityFrameworkCore.Migrations;

namespace BioFresh.Migrations
{
    public partial class Recenzii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preparata",
                table: "Status",
                newName: "Nume");

            migrationBuilder.RenameColumn(
                name: "Livrata",
                table: "Status",
                newName: "Notita");

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Status",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stele",
                table: "Status",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Pret",
                table: "Meniu",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Calorii",
                table: "Meniu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Stele",
                table: "Status");

            migrationBuilder.RenameColumn(
                name: "Nume",
                table: "Status",
                newName: "Preparata");

            migrationBuilder.RenameColumn(
                name: "Notita",
                table: "Status",
                newName: "Livrata");

            migrationBuilder.AlterColumn<string>(
                name: "Pret",
                table: "Meniu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Calorii",
                table: "Meniu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
