using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROIECT.Migrations
{
    /// <inheritdoc />
    public partial class Relatii2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produse_Magazine_MagazinID",
                table: "Produse");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProdus_Clienti_UserID",
                table: "UserProdus");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProdus_Produse_ProdusID",
                table: "UserProdus");

            migrationBuilder.DropIndex(
                name: "IX_Produse_MagazinID",
                table: "Produse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProdus",
                table: "UserProdus");

            migrationBuilder.DropColumn(
                name: "MagazinID",
                table: "Produse");

            migrationBuilder.RenameTable(
                name: "UserProdus",
                newName: "UserProduse");

            migrationBuilder.RenameIndex(
                name: "IX_UserProdus_UserID",
                table: "UserProduse",
                newName: "IX_UserProduse_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserProdus_ProdusID",
                table: "UserProduse",
                newName: "IX_UserProduse_ProdusID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProduse",
                table: "UserProduse",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MagazinProduse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MagazinID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdusID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagazinProduse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagazinProduse_Magazine_MagazinID",
                        column: x => x.MagazinID,
                        principalTable: "Magazine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MagazinProduse_Produse_ProdusID",
                        column: x => x.ProdusID,
                        principalTable: "Produse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MagazinProduse_MagazinID",
                table: "MagazinProduse",
                column: "MagazinID");

            migrationBuilder.CreateIndex(
                name: "IX_MagazinProduse_ProdusID",
                table: "MagazinProduse",
                column: "ProdusID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProduse_Clienti_UserID",
                table: "UserProduse",
                column: "UserID",
                principalTable: "Clienti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProduse_Produse_ProdusID",
                table: "UserProduse",
                column: "ProdusID",
                principalTable: "Produse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProduse_Clienti_UserID",
                table: "UserProduse");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProduse_Produse_ProdusID",
                table: "UserProduse");

            migrationBuilder.DropTable(
                name: "MagazinProduse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProduse",
                table: "UserProduse");

            migrationBuilder.RenameTable(
                name: "UserProduse",
                newName: "UserProdus");

            migrationBuilder.RenameIndex(
                name: "IX_UserProduse_UserID",
                table: "UserProdus",
                newName: "IX_UserProdus_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserProduse_ProdusID",
                table: "UserProdus",
                newName: "IX_UserProdus_ProdusID");

            migrationBuilder.AddColumn<Guid>(
                name: "MagazinID",
                table: "Produse",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProdus",
                table: "UserProdus",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Produse_MagazinID",
                table: "Produse",
                column: "MagazinID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produse_Magazine_MagazinID",
                table: "Produse",
                column: "MagazinID",
                principalTable: "Magazine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProdus_Clienti_UserID",
                table: "UserProdus",
                column: "UserID",
                principalTable: "Clienti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProdus_Produse_ProdusID",
                table: "UserProdus",
                column: "ProdusID",
                principalTable: "Produse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
