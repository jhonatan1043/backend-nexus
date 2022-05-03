using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testnexus.Migrations
{
    public partial class Initialproyectadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "books",
                newName: "gender");

            migrationBuilder.AddColumn<int>(
                name: "MaxBookReg",
                table: "Editorials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAutor",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEditorial",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "birthdate",
                table: "Autores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxBookReg",
                table: "Editorials");

            migrationBuilder.DropColumn(
                name: "IdAutor",
                table: "books");

            migrationBuilder.DropColumn(
                name: "IdEditorial",
                table: "books");

            migrationBuilder.DropColumn(
                name: "birthdate",
                table: "Autores");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "books",
                newName: "Genero");
        }
    }
}
