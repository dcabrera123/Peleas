using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Peleas.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Control",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Apellidos = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Control", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lucha",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Apellidos = table.Column<string>(nullable: false),
                    Celular = table.Column<int>(nullable: false),
                    ConfirmarContraseña = table.Column<string>(nullable: true),
                    ConfirmarCorreo = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Nacimiento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Usu = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lucha", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Luchador",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Apellidos = table.Column<string>(nullable: false),
                    Celular = table.Column<int>(nullable: false),
                    ConfirmarContraseña = table.Column<string>(nullable: true),
                    ConfirmarCorreo = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Nacimiento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Usu = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luchador", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Control");

            migrationBuilder.DropTable(
                name: "Lucha");

            migrationBuilder.DropTable(
                name: "Luchador");
        }
    }
}
