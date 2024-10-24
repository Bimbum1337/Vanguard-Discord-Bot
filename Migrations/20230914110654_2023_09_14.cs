using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatabaseCommands",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Command = table.Column<int>(type: "int", nullable: false),
                    Data1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendAfter = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.DatabaseCommands", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatabaseCommands");
        }
    }
}
