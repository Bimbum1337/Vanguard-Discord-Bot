using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Giveaway",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    WinnersCount = table.Column<int>(type: "int", nullable: false),
                    SecondsLeft = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._Giveaway", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "_GiveawayRecords",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    IsRewardTaken = table.Column<bool>(type: "bit", nullable: false),
                    Giveaway_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._GiveawayRecords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbo._Giveaway._Records_ID",
                        column: x => x.Giveaway_ID,
                        principalTable: "_Giveaway",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX__GiveawayRecords_Giveaway_ID",
                table: "_GiveawayRecords",
                column: "Giveaway_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_GiveawayRecords");

            migrationBuilder.DropTable(
                name: "_Giveaway");
        }
    }
}
