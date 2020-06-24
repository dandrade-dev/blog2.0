using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PWABlog.Migrations
{
    public partial class atualizacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataPostagem",
                table: "Postagens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPostagem",
                table: "Postagens");
        }
    }
}
