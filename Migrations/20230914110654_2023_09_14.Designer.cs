﻿// <auto-generated />
using System;
using BimBot.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BimBot.Migrations
{
    [DbContext(typeof(SRO_VT_BIMBOT))]
    [Migration("20230914110654_2023_09_14")]
    partial class _2023_09_14
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.BlackListWords", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID")
                        .HasName("PK_dbo._BlackListWords_ID");

                    b.ToTable("_BlackListWords", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DatabaseCommands", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Command")
                        .HasColumnType("int");

                    b.Property<string>("Data1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SendAfter")
                        .HasColumnType("datetime2");

                    b.HasKey("ID")
                        .HasName("PK_dbo.DatabaseCommands");

                    b.ToTable("DatabaseCommands", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildCategories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Permission_ID")
                        .HasColumnType("int");

                    b.HasKey("ID")
                        .HasName("PK_dbo._DefaultGuildCategories");

                    b.HasIndex("Permission_ID");

                    b.ToTable("_DefaultGuildCategories", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildCategoriesPermissions", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CanAddReaction")
                        .HasColumnType("int");

                    b.Property<int>("CanAttachFiles")
                        .HasColumnType("int");

                    b.Property<int>("CanConnect")
                        .HasColumnType("int");

                    b.Property<int>("CanCreateInvite")
                        .HasColumnType("int");

                    b.Property<int>("CanCreatePrivateThreads")
                        .HasColumnType("int");

                    b.Property<int>("CanCreatePublicThreads")
                        .HasColumnType("int");

                    b.Property<int>("CanDefeanMembers")
                        .HasColumnType("int");

                    b.Property<int>("CanManageChannel")
                        .HasColumnType("int");

                    b.Property<int>("CanManageMessages")
                        .HasColumnType("int");

                    b.Property<int>("CanManageRoles")
                        .HasColumnType("int");

                    b.Property<int>("CanManageThreads")
                        .HasColumnType("int");

                    b.Property<int>("CanManageWebHooks")
                        .HasColumnType("int");

                    b.Property<int>("CanMentionEveryOne")
                        .HasColumnType("int");

                    b.Property<int>("CanMoveMembers")
                        .HasColumnType("int");

                    b.Property<int>("CanMuteMembers")
                        .HasColumnType("int");

                    b.Property<int>("CanPrioritySpeaker")
                        .HasColumnType("int");

                    b.Property<int>("CanReadMessagesHistory")
                        .HasColumnType("int");

                    b.Property<int>("CanRequestToSpeak")
                        .HasColumnType("int");

                    b.Property<int>("CanSendEmbedLinks")
                        .HasColumnType("int");

                    b.Property<int>("CanSendMessage")
                        .HasColumnType("int");

                    b.Property<int>("CanSendMessagesInThread")
                        .HasColumnType("int");

                    b.Property<int>("CanSendTTS")
                        .HasColumnType("int");

                    b.Property<int>("CanSpeak")
                        .HasColumnType("int");

                    b.Property<int>("CanStartEmbedActivities")
                        .HasColumnType("int");

                    b.Property<int>("CanStream")
                        .HasColumnType("int");

                    b.Property<int>("CanUseApplicationCommands")
                        .HasColumnType("int");

                    b.Property<int>("CanUseExternalEmoji")
                        .HasColumnType("int");

                    b.Property<int>("CanUseExternalStickers")
                        .HasColumnType("int");

                    b.Property<int>("CanUsePrivateThreads")
                        .HasColumnType("int");

                    b.Property<int>("CanUsePublicThreads")
                        .HasColumnType("int");

                    b.Property<int>("CanUseSlashCommands")
                        .HasColumnType("int");

                    b.Property<int>("CanUseVoiceActivation")
                        .HasColumnType("int");

                    b.Property<int>("CanViewChannel")
                        .HasColumnType("int");

                    b.HasKey("ID")
                        .HasName("PK_dbo._DefaultGuildCategoriesPermissions");

                    b.ToTable("_DefaultGuildCategoriesPermissions", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildChannels", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Category_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID")
                        .HasName("PK_dbo._DefaultGuildChannels");

                    b.HasIndex("Category_ID");

                    b.ToTable("_DefaultGuildChannels", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildRoles", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("CanMention")
                        .HasColumnType("bit");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Permission_ID")
                        .HasColumnType("int");

                    b.HasKey("ID")
                        .HasName("PK_dbo._DefaultGuildRoles");

                    b.HasIndex("Permission_ID");

                    b.ToTable("_DefaultGuildRoles", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildRolesPermissions", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("CanAddReaction")
                        .HasColumnType("bit");

                    b.Property<bool>("CanAttachFiles")
                        .HasColumnType("bit");

                    b.Property<bool>("CanBanMembers")
                        .HasColumnType("bit");

                    b.Property<bool>("CanChangeNickName")
                        .HasColumnType("bit");

                    b.Property<bool>("CanConnect")
                        .HasColumnType("bit");

                    b.Property<bool>("CanCreateInvite")
                        .HasColumnType("bit");

                    b.Property<bool>("CanCreatePrivateThreads")
                        .HasColumnType("bit");

                    b.Property<bool>("CanCreatePublicThreads")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDefeanMembers")
                        .HasColumnType("bit");

                    b.Property<bool>("CanKickMembers")
                        .HasColumnType("bit");

                    b.Property<bool>("CanManageChannel")
                        .HasColumnType("bit");

                    b.Property<bool>("CanManageEmojisAndStickers")
                        .HasColumnType("bit");

                    b.Property<bool>("CanManageEvents")
                        .HasColumnType("bit");

                    b.Property<bool>("CanManageGuild")
                        .HasColumnType("bit");

                    b.Property<bool>("CanManageMessages")
                        .HasColumnType("bit");

                    b.Property<bool>("CanManageNickName")
                        .HasColumnType("bit");

                    b.Property<bool>("CanManageRoles")
                        .HasColumnType("bit");

                    b.Property<bool>("CanManageThreads")
                        .HasColumnType("bit");

                    b.Property<bool>("CanManageWebHooks")
                        .HasColumnType("bit");

                    b.Property<bool>("CanMentionEveryOne")
                        .HasColumnType("bit");

                    b.Property<bool>("CanModerateMembers")
                        .HasColumnType("bit");

                    b.Property<bool>("CanMoveMembers")
                        .HasColumnType("bit");

                    b.Property<bool>("CanMuteMembers")
                        .HasColumnType("bit");

                    b.Property<bool>("CanPrioritySpeaker")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReadMessagesHistory")
                        .HasColumnType("bit");

                    b.Property<bool>("CanRequestToSpeak")
                        .HasColumnType("bit");

                    b.Property<bool>("CanSendEmbedLinks")
                        .HasColumnType("bit");

                    b.Property<bool>("CanSendMessage")
                        .HasColumnType("bit");

                    b.Property<bool>("CanSendMessagesInThread")
                        .HasColumnType("bit");

                    b.Property<bool>("CanSendTTS")
                        .HasColumnType("bit");

                    b.Property<bool>("CanSendVoiceMessages")
                        .HasColumnType("bit");

                    b.Property<bool>("CanSpeak")
                        .HasColumnType("bit");

                    b.Property<bool>("CanStartEmbedActivities")
                        .HasColumnType("bit");

                    b.Property<bool>("CanStream")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUseApplicationCommands")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUseExternalEmoji")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUseExternalStickers")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUseSoundBoard")
                        .HasColumnType("bit");

                    b.Property<bool>("CanUseVoiceActivation")
                        .HasColumnType("bit");

                    b.Property<bool>("CanViewAudit")
                        .HasColumnType("bit");

                    b.Property<bool>("CanViewChannel")
                        .HasColumnType("bit");

                    b.Property<bool>("CanViewGuildInsights")
                        .HasColumnType("bit");

                    b.Property<bool>("CanViewMonetizationAnalytics")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("bit");

                    b.HasKey("ID")
                        .HasName("PK_dbo._DefaultGuildRolesPermissions");

                    b.ToTable("_DefaultGuildRolesPermissions", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.Help", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("OptionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionEmote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID")
                        .HasName("PK_dbo._Help_ID");

                    b.ToTable("_Help", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.HelpEmbed", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CustomImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmbedDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmbedTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Help_ID")
                        .HasColumnType("int");

                    b.Property<bool>("MentionUser")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShowDefaultThumbnail")
                        .HasColumnType("bit");

                    b.HasKey("ID")
                        .HasName("PK_dbo._HelpEmbed");

                    b.HasIndex("Help_ID");

                    b.ToTable("_HelpEmbed", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.HelpMessage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Help_ID")
                        .HasColumnType("int");

                    b.Property<bool>("MentionUser")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID")
                        .HasName("PK_dbo._HelpMessage");

                    b.HasIndex("Help_ID");

                    b.ToTable("_HelpMessage", (string)null);
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildCategories", b =>
                {
                    b.HasOne("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildCategoriesPermissions", "CategoriesPermissions")
                        .WithMany("Categories")
                        .HasForeignKey("Permission_ID")
                        .IsRequired()
                        .HasConstraintName("FK_dbo._DefaultGuildCategoriesPermissions._Categories_ID");

                    b.Navigation("CategoriesPermissions");
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildChannels", b =>
                {
                    b.HasOne("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildCategories", "Category")
                        .WithMany("Channels")
                        .HasForeignKey("Category_ID")
                        .IsRequired()
                        .HasConstraintName("FK_dbo._DefaultGuildCategories._Channels_ID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildRoles", b =>
                {
                    b.HasOne("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildRolesPermissions", "RolesPermissions")
                        .WithMany("Roles")
                        .HasForeignKey("Permission_ID")
                        .IsRequired()
                        .HasConstraintName("FK_dbo._DefaultGuildRolesPermissions._Roles_ID");

                    b.Navigation("RolesPermissions");
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.HelpEmbed", b =>
                {
                    b.HasOne("BimBot.Database.SRO_VT_BIMBOT.Help", "Help")
                        .WithMany("HelpEmbeds")
                        .HasForeignKey("Help_ID")
                        .IsRequired()
                        .HasConstraintName("FK_dbo._Help._HelpEmbeds_ID");

                    b.Navigation("Help");
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.HelpMessage", b =>
                {
                    b.HasOne("BimBot.Database.SRO_VT_BIMBOT.Help", "Help")
                        .WithMany("HelpMessages")
                        .HasForeignKey("Help_ID")
                        .IsRequired()
                        .HasConstraintName("FK_dbo._Help._HelpMessages_ID");

                    b.Navigation("Help");
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildCategories", b =>
                {
                    b.Navigation("Channels");
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildCategoriesPermissions", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.DefaultGuildRolesPermissions", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("BimBot.Database.SRO_VT_BIMBOT.Help", b =>
                {
                    b.Navigation("HelpEmbeds");

                    b.Navigation("HelpMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
