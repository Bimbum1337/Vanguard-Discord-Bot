using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_13_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShowThumbnail",
                table: "_HelpEmbed",
                newName: "ShowDefaultThumbnail");

            migrationBuilder.AddColumn<string>(
                name: "CustomThumbnail",
                table: "_HelpEmbed",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionEmote",
                table: "_Help",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomThumbnail",
                table: "_HelpEmbed");

            migrationBuilder.DropColumn(
                name: "OptionEmote",
                table: "_Help");

            migrationBuilder.RenameColumn(
                name: "ShowDefaultThumbnail",
                table: "_HelpEmbed",
                newName: "ShowThumbnail");
        }
    }
}
