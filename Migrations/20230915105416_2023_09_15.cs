using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_InviteLogger",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InviteCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InviterId = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    InviterDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvitedId = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    InvitedDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._InviteLogger", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_InviteLogger");
        }
    }
}
