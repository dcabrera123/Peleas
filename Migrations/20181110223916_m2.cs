using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Peleas.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Luchador");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Lucha");

            migrationBuilder.RenameColumn(
                name: "Usu",
                table: "Luchador",
                newName: "Diciplina");

            migrationBuilder.RenameColumn(
                name: "Nacimiento",
                table: "Luchador",
                newName: "Descripcion3");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Luchador",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "Luchador",
                newName: "Apodo");

            migrationBuilder.RenameColumn(
                name: "ConfirmarCorreo",
                table: "Luchador",
                newName: "Descripcion2");

            migrationBuilder.RenameColumn(
                name: "ConfirmarContraseña",
                table: "Luchador",
                newName: "Descripcion1");

            migrationBuilder.RenameColumn(
                name: "Usu",
                table: "Lucha",
                newName: "Lugar");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Lucha",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "Nacimiento",
                table: "Lucha",
                newName: "Descripcion3");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Lucha",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "Lucha",
                newName: "Diciplina");

            migrationBuilder.RenameColumn(
                name: "ConfirmarCorreo",
                table: "Lucha",
                newName: "Descripcion2");

            migrationBuilder.RenameColumn(
                name: "ConfirmarContraseña",
                table: "Lucha",
                newName: "Descripcion1");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Lucha",
                newName: "Categoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Diciplina",
                table: "Luchador",
                newName: "Usu");

            migrationBuilder.RenameColumn(
                name: "Descripcion3",
                table: "Luchador",
                newName: "Nacimiento");

            migrationBuilder.RenameColumn(
                name: "Descripcion2",
                table: "Luchador",
                newName: "ConfirmarCorreo");

            migrationBuilder.RenameColumn(
                name: "Descripcion1",
                table: "Luchador",
                newName: "ConfirmarContraseña");

            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Luchador",
                newName: "Correo");

            migrationBuilder.RenameColumn(
                name: "Apodo",
                table: "Luchador",
                newName: "Contraseña");

            migrationBuilder.RenameColumn(
                name: "Lugar",
                table: "Lucha",
                newName: "Usu");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Lucha",
                newName: "Correo");

            migrationBuilder.RenameColumn(
                name: "Diciplina",
                table: "Lucha",
                newName: "Contraseña");

            migrationBuilder.RenameColumn(
                name: "Descripcion3",
                table: "Lucha",
                newName: "Nacimiento");

            migrationBuilder.RenameColumn(
                name: "Descripcion2",
                table: "Lucha",
                newName: "ConfirmarCorreo");

            migrationBuilder.RenameColumn(
                name: "Descripcion1",
                table: "Lucha",
                newName: "ConfirmarContraseña");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Lucha",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Lucha",
                newName: "Apellidos");

            migrationBuilder.AddColumn<int>(
                name: "Celular",
                table: "Luchador",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Celular",
                table: "Lucha",
                nullable: false,
                defaultValue: 0);
        }
    }
}
