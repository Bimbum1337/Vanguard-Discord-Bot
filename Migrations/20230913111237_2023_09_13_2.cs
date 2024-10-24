using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_13_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Help",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._Help_ID", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "_HelpEmbed",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmbedTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmbedDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowThumbnail = table.Column<bool>(type: "bit", nullable: false),
                    MentionUser = table.Column<bool>(type: "bit", nullable: false),
                    Help_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._HelpEmbed", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbo._Help._HelpEmbeds_ID",
                        column: x => x.Help_ID,
                        principalTable: "_Help",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "_HelpMessage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MentionUser = table.Column<bool>(type: "bit", nullable: false),
                    Help_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._HelpMessage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbo._Help._HelpMessages_ID",
                        column: x => x.Help_ID,
                        principalTable: "_Help",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX__HelpEmbed_Help_ID",
                table: "_HelpEmbed",
                column: "Help_ID");

            migrationBuilder.CreateIndex(
                name: "IX__HelpMessage_Help_ID",
                table: "_HelpMessage",
                column: "Help_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_HelpEmbed");

            migrationBuilder.DropTable(
                name: "_HelpMessage");

            migrationBuilder.DropTable(
                name: "_Help");
        }
    }
}
