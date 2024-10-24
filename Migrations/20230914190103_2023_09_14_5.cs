using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_14_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_UniqueInformation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._UniqueInformation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "_UniqueInformationRecords",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    Killer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Unique_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._UniqueInformationRecords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbo._UniqueInformation._Records_ID",
                        column: x => x.Unique_ID,
                        principalTable: "_UniqueInformation",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX__UniqueInformationRecords_Unique_ID",
                table: "_UniqueInformationRecords",
                column: "Unique_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_UniqueInformationRecords");

            migrationBuilder.DropTable(
                name: "_UniqueInformation");
        }
    }
}
