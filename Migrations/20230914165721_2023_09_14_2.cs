using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_14_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo.DatabaseCommands",
                table: "DatabaseCommands");

            migrationBuilder.RenameTable(
                name: "DatabaseCommands",
                newName: "_DatabaseCommands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo._DatabaseCommands",
                table: "_DatabaseCommands",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_dbo._DatabaseCommands",
                table: "_DatabaseCommands");

            migrationBuilder.RenameTable(
                name: "_DatabaseCommands",
                newName: "DatabaseCommands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbo.DatabaseCommands",
                table: "DatabaseCommands",
                column: "ID");
        }
    }
}
