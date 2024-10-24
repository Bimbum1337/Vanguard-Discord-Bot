using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BimBot.Migrations
{
    /// <inheritdoc />
    public partial class _2023_09_13_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_DefaultGuildCategoriesPermissions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanCreateInvite = table.Column<int>(type: "int", nullable: false),
                    CanManageChannel = table.Column<int>(type: "int", nullable: false),
                    CanAddReaction = table.Column<int>(type: "int", nullable: false),
                    CanViewChannel = table.Column<int>(type: "int", nullable: false),
                    CanSendMessage = table.Column<int>(type: "int", nullable: false),
                    CanSendTTS = table.Column<int>(type: "int", nullable: false),
                    CanManageMessages = table.Column<int>(type: "int", nullable: false),
                    CanSendEmbedLinks = table.Column<int>(type: "int", nullable: false),
                    CanAttachFiles = table.Column<int>(type: "int", nullable: false),
                    CanReadMessagesHistory = table.Column<int>(type: "int", nullable: false),
                    CanMentionEveryOne = table.Column<int>(type: "int", nullable: false),
                    CanUseExternalEmoji = table.Column<int>(type: "int", nullable: false),
                    CanConnect = table.Column<int>(type: "int", nullable: false),
                    CanSpeak = table.Column<int>(type: "int", nullable: false),
                    CanMuteMembers = table.Column<int>(type: "int", nullable: false),
                    CanDefeanMembers = table.Column<int>(type: "int", nullable: false),
                    CanMoveMembers = table.Column<int>(type: "int", nullable: false),
                    CanUseVoiceActivation = table.Column<int>(type: "int", nullable: false),
                    CanManageRoles = table.Column<int>(type: "int", nullable: false),
                    CanManageWebHooks = table.Column<int>(type: "int", nullable: false),
                    CanPrioritySpeaker = table.Column<int>(type: "int", nullable: false),
                    CanStream = table.Column<int>(type: "int", nullable: false),
                    CanUseSlashCommands = table.Column<int>(type: "int", nullable: false),
                    CanUseApplicationCommands = table.Column<int>(type: "int", nullable: false),
                    CanRequestToSpeak = table.Column<int>(type: "int", nullable: false),
                    CanManageThreads = table.Column<int>(type: "int", nullable: false),
                    CanCreatePublicThreads = table.Column<int>(type: "int", nullable: false),
                    CanCreatePrivateThreads = table.Column<int>(type: "int", nullable: false),
                    CanUsePublicThreads = table.Column<int>(type: "int", nullable: false),
                    CanUsePrivateThreads = table.Column<int>(type: "int", nullable: false),
                    CanUseExternalStickers = table.Column<int>(type: "int", nullable: false),
                    CanSendMessagesInThread = table.Column<int>(type: "int", nullable: false),
                    CanStartEmbedActivities = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._DefaultGuildCategoriesPermissions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "_DefaultGuildRolesPermissions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanCreateInvite = table.Column<bool>(type: "bit", nullable: false),
                    CanKickMembers = table.Column<bool>(type: "bit", nullable: false),
                    CanBanMembers = table.Column<bool>(type: "bit", nullable: false),
                    IsAdministrator = table.Column<bool>(type: "bit", nullable: false),
                    CanManageChannel = table.Column<bool>(type: "bit", nullable: false),
                    CanManageGuild = table.Column<bool>(type: "bit", nullable: false),
                    CanAddReaction = table.Column<bool>(type: "bit", nullable: false),
                    CanViewAudit = table.Column<bool>(type: "bit", nullable: false),
                    CanViewGuildInsights = table.Column<bool>(type: "bit", nullable: false),
                    CanViewChannel = table.Column<bool>(type: "bit", nullable: false),
                    CanSendMessage = table.Column<bool>(type: "bit", nullable: false),
                    CanSendTTS = table.Column<bool>(type: "bit", nullable: false),
                    CanManageMessages = table.Column<bool>(type: "bit", nullable: false),
                    CanSendEmbedLinks = table.Column<bool>(type: "bit", nullable: false),
                    CanAttachFiles = table.Column<bool>(type: "bit", nullable: false),
                    CanReadMessagesHistory = table.Column<bool>(type: "bit", nullable: false),
                    CanMentionEveryOne = table.Column<bool>(type: "bit", nullable: false),
                    CanUseExternalEmoji = table.Column<bool>(type: "bit", nullable: false),
                    CanConnect = table.Column<bool>(type: "bit", nullable: false),
                    CanSpeak = table.Column<bool>(type: "bit", nullable: false),
                    CanMuteMembers = table.Column<bool>(type: "bit", nullable: false),
                    CanDefeanMembers = table.Column<bool>(type: "bit", nullable: false),
                    CanMoveMembers = table.Column<bool>(type: "bit", nullable: false),
                    CanUseVoiceActivation = table.Column<bool>(type: "bit", nullable: false),
                    CanPrioritySpeaker = table.Column<bool>(type: "bit", nullable: false),
                    CanStream = table.Column<bool>(type: "bit", nullable: false),
                    CanChangeNickName = table.Column<bool>(type: "bit", nullable: false),
                    CanManageNickName = table.Column<bool>(type: "bit", nullable: false),
                    CanManageRoles = table.Column<bool>(type: "bit", nullable: false),
                    CanManageWebHooks = table.Column<bool>(type: "bit", nullable: false),
                    CanManageEmojisAndStickers = table.Column<bool>(type: "bit", nullable: false),
                    CanUseApplicationCommands = table.Column<bool>(type: "bit", nullable: false),
                    CanRequestToSpeak = table.Column<bool>(type: "bit", nullable: false),
                    CanManageEvents = table.Column<bool>(type: "bit", nullable: false),
                    CanManageThreads = table.Column<bool>(type: "bit", nullable: false),
                    CanCreatePublicThreads = table.Column<bool>(type: "bit", nullable: false),
                    CanCreatePrivateThreads = table.Column<bool>(type: "bit", nullable: false),
                    CanUseExternalStickers = table.Column<bool>(type: "bit", nullable: false),
                    CanSendMessagesInThread = table.Column<bool>(type: "bit", nullable: false),
                    CanStartEmbedActivities = table.Column<bool>(type: "bit", nullable: false),
                    CanModerateMembers = table.Column<bool>(type: "bit", nullable: false),
                    CanUseSoundBoard = table.Column<bool>(type: "bit", nullable: false),
                    CanViewMonetizationAnalytics = table.Column<bool>(type: "bit", nullable: false),
                    CanSendVoiceMessages = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._DefaultGuildRolesPermissions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "_DefaultGuildCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._DefaultGuildCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbo._DefaultGuildCategoriesPermissions._Categories_ID",
                        column: x => x.Permission_ID,
                        principalTable: "_DefaultGuildCategoriesPermissions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "_DefaultGuildRoles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    CanMention = table.Column<bool>(type: "bit", nullable: false),
                    Permission_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._DefaultGuildRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbo._DefaultGuildRolesPermissions._Roles_ID",
                        column: x => x.Permission_ID,
                        principalTable: "_DefaultGuildRolesPermissions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "_DefaultGuildChannels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo._DefaultGuildChannels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbo._DefaultGuildCategories._Channels_ID",
                        column: x => x.Category_ID,
                        principalTable: "_DefaultGuildCategories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX__DefaultGuildCategories_Permission_ID",
                table: "_DefaultGuildCategories",
                column: "Permission_ID");

            migrationBuilder.CreateIndex(
                name: "IX__DefaultGuildChannels_Category_ID",
                table: "_DefaultGuildChannels",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX__DefaultGuildRoles_Permission_ID",
                table: "_DefaultGuildRoles",
                column: "Permission_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_DefaultGuildChannels");

            migrationBuilder.DropTable(
                name: "_DefaultGuildRoles");

            migrationBuilder.DropTable(
                name: "_DefaultGuildCategories");

            migrationBuilder.DropTable(
                name: "_DefaultGuildRolesPermissions");

            migrationBuilder.DropTable(
                name: "_DefaultGuildCategoriesPermissions");
        }
    }
}
