using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_PollsLogger",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    AnswersCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._PollsLogger", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "_PollsLoggerRecords",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poll_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._PollsLoggerRecords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbo._PollsLogger._Records_ID",
                        column: x => x.Poll_ID,
                        principalTable: "_PollsLogger",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX__PollsLoggerRecords_Poll_ID",
                table: "_PollsLoggerRecords",
                column: "Poll_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_PollsLoggerRecords");

            migrationBuilder.DropTable(
                name: "_PollsLogger");
        }
    }
}
