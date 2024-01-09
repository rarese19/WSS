using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROIECT.Migrations
{
    /// <inheritdoc />
    public partial class Relatii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MagazinID",
                table: "Produse",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "Inaltime",
                table: "Partii",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "GradDificultate",
                table: "Partii",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "StatiuneID",
                table: "Partii",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StatiuneID",
                table: "Magazine",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NumarTelefon",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Parola",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NumarTelefon",
                table: "Angajati",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "MagazinID",
                table: "Angajati",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "UserProdus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cantiate = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdusID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProdus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProdus_Clienti_UserID",
                        column: x => x.UserID,
                        principalTable: "Clienti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProdus_Produse_ProdusID",
                        column: x => x.ProdusID,
                        principalTable: "Produse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produse_MagazinID",
                table: "Produse",
                column: "MagazinID");

            migrationBuilder.CreateIndex(
                name: "IX_Partii_StatiuneID",
                table: "Partii",
                column: "StatiuneID");

            migrationBuilder.CreateIndex(
                name: "IX_Magazine_StatiuneID",
                table: "Magazine",
                column: "StatiuneID");

            migrationBuilder.CreateIndex(
                name: "IX_Angajati_MagazinID",
                table: "Angajati",
                column: "MagazinID");

            migrationBuilder.CreateIndex(
                name: "IX_UserProdus_ProdusID",
                table: "UserProdus",
                column: "ProdusID");

            migrationBuilder.CreateIndex(
                name: "IX_UserProdus_UserID",
                table: "UserProdus",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Angajati_Magazine_MagazinID",
                table: "Angajati",
                column: "MagazinID",
                principalTable: "Magazine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Magazine_Statiuni_StatiuneID",
                table: "Magazine",
                column: "StatiuneID",
                principalTable: "Statiuni",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partii_Statiuni_StatiuneID",
                table: "Partii",
                column: "StatiuneID",
                principalTable: "Statiuni",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produse_Magazine_MagazinID",
                table: "Produse",
                column: "MagazinID",
                principalTable: "Magazine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Angajati_Magazine_MagazinID",
                table: "Angajati");

            migrationBuilder.DropForeignKey(
                name: "FK_Magazine_Statiuni_StatiuneID",
                table: "Magazine");

            migrationBuilder.DropForeignKey(
                name: "FK_Partii_Statiuni_StatiuneID",
                table: "Partii");

            migrationBuilder.DropForeignKey(
                name: "FK_Produse_Magazine_MagazinID",
                table: "Produse");

            migrationBuilder.DropTable(
                name: "UserProdus");

            migrationBuilder.DropIndex(
                name: "IX_Produse_MagazinID",
                table: "Produse");

            migrationBuilder.DropIndex(
                name: "IX_Partii_StatiuneID",
                table: "Partii");

            migrationBuilder.DropIndex(
                name: "IX_Magazine_StatiuneID",
                table: "Magazine");

            migrationBuilder.DropIndex(
                name: "IX_Angajati_MagazinID",
                table: "Angajati");

            migrationBuilder.DropColumn(
                name: "MagazinID",
                table: "Produse");

            migrationBuilder.DropColumn(
                name: "StatiuneID",
                table: "Partii");

            migrationBuilder.DropColumn(
                name: "StatiuneID",
                table: "Magazine");

            migrationBuilder.DropColumn(
                name: "Parola",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "MagazinID",
                table: "Angajati");

            migrationBuilder.AlterColumn<int>(
                name: "Inaltime",
                table: "Partii",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GradDificultate",
                table: "Partii",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumarTelefon",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumarTelefon",
                table: "Angajati",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
