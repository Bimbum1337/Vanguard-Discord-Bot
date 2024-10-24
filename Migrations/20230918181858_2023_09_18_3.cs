using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_18_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsWinner",
                table: "_GiveawayRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWinner",
                table: "_GiveawayRecords");
        }
    }
}
