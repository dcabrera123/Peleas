using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Peleas.Migrations
{
    public partial class p2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Luchador",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Luchador",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
