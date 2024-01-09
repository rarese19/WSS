using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROIECT.Migrations
{
    /// <inheritdoc />
    public partial class Identity1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdresaMail",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "Parola",
                table: "Clienti");

            migrationBuilder.RenameColumn(
                name: "NumarTelefon",
                table: "Clienti",
                newName: "UserName");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Clienti",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Clienti",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Clienti",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Clienti",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Clienti",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Clienti",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Clienti");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Clienti",
                newName: "NumarTelefon");

            migrationBuilder.AddColumn<string>(
                name: "AdresaMail",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Clienti",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Clienti",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parola",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
