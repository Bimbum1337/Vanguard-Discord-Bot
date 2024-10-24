using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_18_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "MessageId",
                table: "_Giveaway",
                type: "decimal(20,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "ChannelID",
                table: "_Giveaway",
                type: "decimal(20,0)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChannelID",
                table: "_Giveaway");

            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "_Giveaway",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)");
        }
    }
}
