using Microsoft.EntityFrameworkCore.Migrations;

namespace Uplift.DataAccess.Migrations
{
    public partial class AddPDVTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PDVId",
                table: "StavkeFaktura",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StavkeFaktura_PDVId",
                table: "StavkeFaktura",
                column: "PDVId");

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeFaktura_PDV_PDVId",
                table: "StavkeFaktura",
                column: "PDVId",
                principalTable: "PDV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkeFaktura_PDV_PDVId",
                table: "StavkeFaktura");

            migrationBuilder.DropIndex(
                name: "IX_StavkeFaktura_PDVId",
                table: "StavkeFaktura");

            migrationBuilder.DropColumn(
                name: "PDVId",
                table: "StavkeFaktura");
        }
    }
}
