using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorTest.ServerSide.Migrations
{
    /// <inheritdoc />
    public partial class InitKanji : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kanji",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Char = table.Column<string>(type: "TEXT", nullable: false),
                    Meanings = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kanji", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kanji");
        }
    }
}
