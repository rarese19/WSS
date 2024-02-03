using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROIECT.Migrations
{
    /// <inheritdoc />
    public partial class magazinprodus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stoc",
                table: "Produse");

            migrationBuilder.AddColumn<string>(
                name: "Cantitate",
                table: "MagazinProduse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantitate",
                table: "MagazinProduse");

            migrationBuilder.AddColumn<int>(
                name: "Stoc",
                table: "Produse",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
