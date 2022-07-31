using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorTest.ServerSide.Migrations
{
    /// <inheritdoc />
    public partial class RenameKanjis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Readings_Kanji_KanjiId",
                table: "Readings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kanji",
                table: "Kanji");

            migrationBuilder.RenameTable(
                name: "Kanji",
                newName: "Kanjis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kanjis",
                table: "Kanjis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Readings_Kanjis_KanjiId",
                table: "Readings",
                column: "KanjiId",
                principalTable: "Kanjis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Readings_Kanjis_KanjiId",
                table: "Readings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kanjis",
                table: "Kanjis");

            migrationBuilder.RenameTable(
                name: "Kanjis",
                newName: "Kanji");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kanji",
                table: "Kanji",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Readings_Kanji_KanjiId",
                table: "Readings",
                column: "KanjiId",
                principalTable: "Kanji",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
