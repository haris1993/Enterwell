using Microsoft.EntityFrameworkCore.Migrations;

namespace Uplift.DataAccess.Migrations
{
    public partial class updateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "StavkeFaktura");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Proizvod");

            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "StavkeFaktura",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Kolicina",
                table: "Faktura",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "StavkeFaktura");

            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "Faktura");

            migrationBuilder.AddColumn<int>(
                name: "Kolicina",
                table: "StavkeFaktura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Proizvod",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
