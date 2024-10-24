using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_14_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendAfter",
                table: "_DatabaseCommands");

            migrationBuilder.AddColumn<string>(
                name: "Data8",
                table: "_DatabaseCommands",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data8",
                table: "_DatabaseCommands");

            migrationBuilder.AddColumn<DateTime>(
                name: "SendAfter",
                table: "_DatabaseCommands",
                type: "datetime2",
                nullable: true);
        }
    }
}
