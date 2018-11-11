using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Peleas.Migrations
{
    public partial class p : Migration
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
                    Categoria = table.Column<string>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 40, nullable: false),
                    Descripcion1 = table.Column<string>(nullable: true),
                    Descripcion2 = table.Column<string>(nullable: true),
                    Descripcion3 = table.Column<string>(nullable: true),
                    Diciplina = table.Column<string>(nullable: false),
                    Fecha = table.Column<string>(nullable: false),
                    Lugar = table.Column<string>(nullable: false)
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
                    Categoria = table.Column<string>(nullable: false),
                    Descripcion1 = table.Column<string>(nullable: true),
                    Descripcion2 = table.Column<string>(nullable: true),
                    Descripcion3 = table.Column<string>(nullable: true),
                    Diciplina = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false)
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
