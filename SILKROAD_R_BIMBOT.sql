USE [SILKROAD_R_BIMBOT]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_BlackListWords]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_BlackListWords](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Word] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo._BlackListWords_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_DatabaseCommands]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_DatabaseCommands](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Command] [int] NOT NULL,
	[Data1] [nvarchar](max) NULL,
	[Data2] [nvarchar](max) NULL,
	[Data3] [nvarchar](max) NULL,
	[Data4] [nvarchar](max) NULL,
	[Data5] [nvarchar](max) NULL,
	[Data6] [nvarchar](max) NULL,
	[Data7] [nvarchar](max) NULL,
	[Data8] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo._DatabaseCommands] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_DefaultGuildCategories]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_DefaultGuildCategories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Permission_ID] [int] NOT NULL,
 CONSTRAINT [PK_dbo._DefaultGuildCategories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_DefaultGuildCategoriesPermissions]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_DefaultGuildCategoriesPermissions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CanCreateInvite] [int] NOT NULL,
	[CanManageChannel] [int] NOT NULL,
	[CanAddReaction] [int] NOT NULL,
	[CanViewChannel] [int] NOT NULL,
	[CanSendMessage] [int] NOT NULL,
	[CanSendTTS] [int] NOT NULL,
	[CanManageMessages] [int] NOT NULL,
	[CanSendEmbedLinks] [int] NOT NULL,
	[CanAttachFiles] [int] NOT NULL,
	[CanReadMessagesHistory] [int] NOT NULL,
	[CanMentionEveryOne] [int] NOT NULL,
	[CanUseExternalEmoji] [int] NOT NULL,
	[CanConnect] [int] NOT NULL,
	[CanSpeak] [int] NOT NULL,
	[CanMuteMembers] [int] NOT NULL,
	[CanDefeanMembers] [int] NOT NULL,
	[CanMoveMembers] [int] NOT NULL,
	[CanUseVoiceActivation] [int] NOT NULL,
	[CanManageRoles] [int] NOT NULL,
	[CanManageWebHooks] [int] NOT NULL,
	[CanPrioritySpeaker] [int] NOT NULL,
	[CanStream] [int] NOT NULL,
	[CanUseSlashCommands] [int] NOT NULL,
	[CanUseApplicationCommands] [int] NOT NULL,
	[CanRequestToSpeak] [int] NOT NULL,
	[CanManageThreads] [int] NOT NULL,
	[CanCreatePublicThreads] [int] NOT NULL,
	[CanCreatePrivateThreads] [int] NOT NULL,
	[CanUsePublicThreads] [int] NOT NULL,
	[CanUsePrivateThreads] [int] NOT NULL,
	[CanUseExternalStickers] [int] NOT NULL,
	[CanSendMessagesInThread] [int] NOT NULL,
	[CanStartEmbedActivities] [int] NOT NULL,
 CONSTRAINT [PK_dbo._DefaultGuildCategoriesPermissions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_DefaultGuildChannels]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_DefaultGuildChannels](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Category_ID] [int] NOT NULL,
 CONSTRAINT [PK_dbo._DefaultGuildChannels] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_DefaultGuildRoles]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_DefaultGuildRoles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Color] [int] NOT NULL,
	[CanMention] [bit] NOT NULL,
	[Permission_ID] [int] NOT NULL,
 CONSTRAINT [PK_dbo._DefaultGuildRoles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_DefaultGuildRolesPermissions]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_DefaultGuildRolesPermissions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CanCreateInvite] [bit] NOT NULL,
	[CanKickMembers] [bit] NOT NULL,
	[CanBanMembers] [bit] NOT NULL,
	[IsAdministrator] [bit] NOT NULL,
	[CanManageChannel] [bit] NOT NULL,
	[CanManageGuild] [bit] NOT NULL,
	[CanAddReaction] [bit] NOT NULL,
	[CanViewAudit] [bit] NOT NULL,
	[CanViewGuildInsights] [bit] NOT NULL,
	[CanViewChannel] [bit] NOT NULL,
	[CanSendMessage] [bit] NOT NULL,
	[CanSendTTS] [bit] NOT NULL,
	[CanManageMessages] [bit] NOT NULL,
	[CanSendEmbedLinks] [bit] NOT NULL,
	[CanAttachFiles] [bit] NOT NULL,
	[CanReadMessagesHistory] [bit] NOT NULL,
	[CanMentionEveryOne] [bit] NOT NULL,
	[CanUseExternalEmoji] [bit] NOT NULL,
	[CanConnect] [bit] NOT NULL,
	[CanSpeak] [bit] NOT NULL,
	[CanMuteMembers] [bit] NOT NULL,
	[CanDefeanMembers] [bit] NOT NULL,
	[CanMoveMembers] [bit] NOT NULL,
	[CanUseVoiceActivation] [bit] NOT NULL,
	[CanPrioritySpeaker] [bit] NOT NULL,
	[CanStream] [bit] NOT NULL,
	[CanChangeNickName] [bit] NOT NULL,
	[CanManageNickName] [bit] NOT NULL,
	[CanManageRoles] [bit] NOT NULL,
	[CanManageWebHooks] [bit] NOT NULL,
	[CanManageEmojisAndStickers] [bit] NOT NULL,
	[CanUseApplicationCommands] [bit] NOT NULL,
	[CanRequestToSpeak] [bit] NOT NULL,
	[CanManageEvents] [bit] NOT NULL,
	[CanManageThreads] [bit] NOT NULL,
	[CanCreatePublicThreads] [bit] NOT NULL,
	[CanCreatePrivateThreads] [bit] NOT NULL,
	[CanUseExternalStickers] [bit] NOT NULL,
	[CanSendMessagesInThread] [bit] NOT NULL,
	[CanStartEmbedActivities] [bit] NOT NULL,
	[CanModerateMembers] [bit] NOT NULL,
	[CanUseSoundBoard] [bit] NOT NULL,
	[CanViewMonetizationAnalytics] [bit] NOT NULL,
	[CanSendVoiceMessages] [bit] NOT NULL,
 CONSTRAINT [PK_dbo._DefaultGuildRolesPermissions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_DefaultSentMessages]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_DefaultSentMessages](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ChannelID] [decimal](20, 0) NOT NULL,
	[MessageID] [decimal](20, 0) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_dbo._DefaultSentMessages] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_Giveaway]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_Giveaway](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MessageId] [decimal](20, 0) NOT NULL,
	[WinnersCount] [int] NOT NULL,
	[SecondsLeft] [decimal](20, 0) NOT NULL,
	[ChannelID] [decimal](20, 0) NOT NULL,
 CONSTRAINT [PK_dbo._Giveaway] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_GiveawayRecords]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_GiveawayRecords](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [decimal](20, 0) NOT NULL,
	[IsRewardTaken] [bit] NOT NULL,
	[Giveaway_ID] [int] NOT NULL,
	[IsWinner] [bit] NOT NULL,
 CONSTRAINT [PK_dbo._GiveawayRecords] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_Help]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_Help](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OptionName] [nvarchar](max) NOT NULL,
	[OptionKey] [nvarchar](max) NOT NULL,
	[OptionDescription] [nvarchar](max) NOT NULL,
	[OptionEmote] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo._Help_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_HelpEmbed]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_HelpEmbed](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NULL,
	[EmbedTitle] [nvarchar](max) NOT NULL,
	[EmbedDescription] [nvarchar](max) NOT NULL,
	[ShowDefaultThumbnail] [bit] NOT NULL,
	[MentionUser] [bit] NOT NULL,
	[Help_ID] [int] NOT NULL,
	[CustomImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo._HelpEmbed] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_HelpMessage]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_HelpMessage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[MentionUser] [bit] NOT NULL,
	[Help_ID] [int] NOT NULL,
 CONSTRAINT [PK_dbo._HelpMessage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_InviteLogger]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_InviteLogger](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InviteCode] [nvarchar](max) NOT NULL,
	[InviterId] [decimal](20, 0) NOT NULL,
	[InviterDisplayName] [nvarchar](max) NOT NULL,
	[InvitedId] [decimal](20, 0) NOT NULL,
	[InvitedDisplayName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo._InviteLogger] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_PollsLogger]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_PollsLogger](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MessageID] [decimal](20, 0) NOT NULL,
	[AnswersCount] [int] NOT NULL,
 CONSTRAINT [PK_dbo._PollsLogger] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_PollsLoggerRecords]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_PollsLoggerRecords](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [decimal](20, 0) NOT NULL,
	[Feedback] [nvarchar](max) NULL,
	[Poll_ID] [int] NOT NULL,
	[AnswerID] [int] NOT NULL,
 CONSTRAINT [PK_dbo._PollsLoggerRecords] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_TicketSystem]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_TicketSystem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TicketID] [int] NOT NULL,
	[UserID] [decimal](20, 0) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_dbo._TicketSystem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_UniqueInformation]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_UniqueInformation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ImageUrl] [nvarchar](max) NOT NULL,
	[Emote] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo._UniqueInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[_UniqueInformationRecords]    Script Date: 10/12/2024 09:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_UniqueInformationRecords](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[State] [bit] NOT NULL,
	[Killer] [nvarchar](max) NULL,
	[DateTime] [datetime2](7) NOT NULL,
	[Unique_ID] [int] NOT NULL,
 CONSTRAINT [PK_dbo._UniqueInformationRecords] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913093033_2023_09_13', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913111237_2023_09_13_2', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913181906_2023_09_13_3', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913183220_2023_09_13_4', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913201341_2023_09_13_5', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914110654_2023_09_14', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914165721_2023_09_14_2', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914172830_2023_09_14_3', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914173120_2023_09_14_4', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914190103_2023_09_14_5', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230914193934_2023_09_14_6', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230915105416_2023_09_15', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230916155951_2023_09_16', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230916163513_2023_09_16_1', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230917085457_2023_09_17', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230917204706_2023_09_17_1', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230918171142_2023_09_18', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230918171516_2023_09_18_2', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230918181858_2023_09_18_3', N'7.0.11')
GO
SET IDENTITY_INSERT [dbo].[_BlackListWords] ON 

INSERT [dbo].[_BlackListWords] ([ID], [Word]) VALUES (1, N'Bimbum')
SET IDENTITY_INSERT [dbo].[_BlackListWords] OFF
GO
SET IDENTITY_INSERT [dbo].[_DefaultGuildCategories] ON 

INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (1, N'TICKETS', 2)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (2, N'ANNOUNCEMENTS', 2)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (3, N'WELCOME AREA', 2)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (4, N'DONATION LIST', 2)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (7, N'PUBLIC', 4)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (8, N'INFORMATION', 2)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (9, N'NITRO BOOSTER', 2)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (10, N'GIVEAWAYS', 2)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (11, N'SUPPORT AREA', 4)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (12, N'CONTENT AREA', 4)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (13, N'INTERNATIONAL', 4)
INSERT [dbo].[_DefaultGuildCategories] ([ID], [Name], [Permission_ID]) VALUES (14, N'GAME LOGGER', 2)
SET IDENTITY_INSERT [dbo].[_DefaultGuildCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[_DefaultGuildCategoriesPermissions] ON 

INSERT [dbo].[_DefaultGuildCategoriesPermissions] ([ID], [CanCreateInvite], [CanManageChannel], [CanAddReaction], [CanViewChannel], [CanSendMessage], [CanSendTTS], [CanManageMessages], [CanSendEmbedLinks], [CanAttachFiles], [CanReadMessagesHistory], [CanMentionEveryOne], [CanUseExternalEmoji], [CanConnect], [CanSpeak], [CanMuteMembers], [CanDefeanMembers], [CanMoveMembers], [CanUseVoiceActivation], [CanManageRoles], [CanManageWebHooks], [CanPrioritySpeaker], [CanStream], [CanUseSlashCommands], [CanUseApplicationCommands], [CanRequestToSpeak], [CanManageThreads], [CanCreatePublicThreads], [CanCreatePrivateThreads], [CanUsePublicThreads], [CanUsePrivateThreads], [CanUseExternalStickers], [CanSendMessagesInThread], [CanStartEmbedActivities]) VALUES (2, 0, 2, 0, 2, 1, 1, 1, 1, 1, 0, 1, 0, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[_DefaultGuildCategoriesPermissions] ([ID], [CanCreateInvite], [CanManageChannel], [CanAddReaction], [CanViewChannel], [CanSendMessage], [CanSendTTS], [CanManageMessages], [CanSendEmbedLinks], [CanAttachFiles], [CanReadMessagesHistory], [CanMentionEveryOne], [CanUseExternalEmoji], [CanConnect], [CanSpeak], [CanMuteMembers], [CanDefeanMembers], [CanMoveMembers], [CanUseVoiceActivation], [CanManageRoles], [CanManageWebHooks], [CanPrioritySpeaker], [CanStream], [CanUseSlashCommands], [CanUseApplicationCommands], [CanRequestToSpeak], [CanManageThreads], [CanCreatePublicThreads], [CanCreatePrivateThreads], [CanUsePublicThreads], [CanUsePrivateThreads], [CanUseExternalStickers], [CanSendMessagesInThread], [CanStartEmbedActivities]) VALUES (4, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[_DefaultGuildCategoriesPermissions] OFF
GO
SET IDENTITY_INSERT [dbo].[_DefaultGuildChannels] ON 

INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (1, N'🎫┇create-a-ticket', 1)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (2, N'📢┇announcements', 2)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (3, N'📢┇announcements-tr', 2)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (4, N'📜┇changelogs', 2)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (5, N'📑┇vote', 2)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (7, N'👋┇welcome', 3)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (8, N'🏴󠁡󠁦󠁬󠁯󠁧󠁿┇invite-track', 3)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (9, N'💰┇donate-prices', 4)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (10, N'💸EG┇egp-prices', 4)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (12, N'💸TR┇tr-prices', 4)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (13, N'💬┇public-chat', 7)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (14, N'📷┇media', 7)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (15, N'🈸┇guild-requests', 7)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (16, N'🈸┇party-requests', 7)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (17, N'🏛️┇market-place', 7)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (18, N'👋┇partners', 7)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (19, N'🤖┇bot-spam', 7)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (20, N'🔗┇links', 8)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (21, N'ℹ️┇server-info', 8)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (22, N'📅┇dates', 8)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (23, N'🔂┇boosters-benifits', 9)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (24, N'🎁┇giveaways', 10)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (25, N'🎁┇facebook', 10)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (26, N'🎁┇elitepvpers', 10)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (28, N'🎁┇partners', 10)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (29, N'🎁┇beta-events', 10)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (30, N'🎁┇invite-event', 10)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (31, N'❓┇ask-questions', 11)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (32, N'👍┇suggestions', 11)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (33, N'📑┇bugs-report', 11)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (35, N'📑┇players-report', 11)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (36, N'🎙️┇live', 12)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (37, N'📹┇short-videos', 12)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (38, N'العربية┇💬', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (39, N'💬┇turkish-sohbet', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (40, N'💬┇philippines', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (41, N'💬┇portugese', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (42, N'💬┇german', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (43, N'💬┇polski', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (44, N'💬┇francais', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (45, N'💬┇de', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (46, N'💬┇espanol', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (47, N'💬┇romanian', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (48, N'💬┇poland', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (49, N'💬┇hungary', 13)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (50, N'📑┇GENERAL-GLOBALS', 14)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (51, N'📑┇MARKET-GLOBALS', 14)
INSERT [dbo].[_DefaultGuildChannels] ([ID], [Name], [Category_ID]) VALUES (52, N'📑┇UNIQUES', 14)
SET IDENTITY_INSERT [dbo].[_DefaultGuildChannels] OFF
GO
SET IDENTITY_INSERT [dbo].[_DefaultGuildRoles] ON 

INSERT [dbo].[_DefaultGuildRoles] ([ID], [Name], [Color], [CanMention], [Permission_ID]) VALUES (1, N'Administrator', 15158332, 1, 1)
INSERT [dbo].[_DefaultGuildRoles] ([ID], [Name], [Color], [CanMention], [Permission_ID]) VALUES (2, N'Moderators', 3066993, 1, 2)
INSERT [dbo].[_DefaultGuildRoles] ([ID], [Name], [Color], [CanMention], [Permission_ID]) VALUES (5, N'Server Boosters', 10181046, 1, 4)
INSERT [dbo].[_DefaultGuildRoles] ([ID], [Name], [Color], [CanMention], [Permission_ID]) VALUES (6, N'Streamers', 7419530, 1, 4)
INSERT [dbo].[_DefaultGuildRoles] ([ID], [Name], [Color], [CanMention], [Permission_ID]) VALUES (7, N'Guild Master', 15105570, 1, 4)
SET IDENTITY_INSERT [dbo].[_DefaultGuildRoles] OFF
GO
SET IDENTITY_INSERT [dbo].[_DefaultGuildRolesPermissions] ON 

INSERT [dbo].[_DefaultGuildRolesPermissions] ([ID], [CanCreateInvite], [CanKickMembers], [CanBanMembers], [IsAdministrator], [CanManageChannel], [CanManageGuild], [CanAddReaction], [CanViewAudit], [CanViewGuildInsights], [CanViewChannel], [CanSendMessage], [CanSendTTS], [CanManageMessages], [CanSendEmbedLinks], [CanAttachFiles], [CanReadMessagesHistory], [CanMentionEveryOne], [CanUseExternalEmoji], [CanConnect], [CanSpeak], [CanMuteMembers], [CanDefeanMembers], [CanMoveMembers], [CanUseVoiceActivation], [CanPrioritySpeaker], [CanStream], [CanChangeNickName], [CanManageNickName], [CanManageRoles], [CanManageWebHooks], [CanManageEmojisAndStickers], [CanUseApplicationCommands], [CanRequestToSpeak], [CanManageEvents], [CanManageThreads], [CanCreatePublicThreads], [CanCreatePrivateThreads], [CanUseExternalStickers], [CanSendMessagesInThread], [CanStartEmbedActivities], [CanModerateMembers], [CanUseSoundBoard], [CanViewMonetizationAnalytics], [CanSendVoiceMessages]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[_DefaultGuildRolesPermissions] ([ID], [CanCreateInvite], [CanKickMembers], [CanBanMembers], [IsAdministrator], [CanManageChannel], [CanManageGuild], [CanAddReaction], [CanViewAudit], [CanViewGuildInsights], [CanViewChannel], [CanSendMessage], [CanSendTTS], [CanManageMessages], [CanSendEmbedLinks], [CanAttachFiles], [CanReadMessagesHistory], [CanMentionEveryOne], [CanUseExternalEmoji], [CanConnect], [CanSpeak], [CanMuteMembers], [CanDefeanMembers], [CanMoveMembers], [CanUseVoiceActivation], [CanPrioritySpeaker], [CanStream], [CanChangeNickName], [CanManageNickName], [CanManageRoles], [CanManageWebHooks], [CanManageEmojisAndStickers], [CanUseApplicationCommands], [CanRequestToSpeak], [CanManageEvents], [CanManageThreads], [CanCreatePublicThreads], [CanCreatePrivateThreads], [CanUseExternalStickers], [CanSendMessagesInThread], [CanStartEmbedActivities], [CanModerateMembers], [CanUseSoundBoard], [CanViewMonetizationAnalytics], [CanSendVoiceMessages]) VALUES (2, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[_DefaultGuildRolesPermissions] ([ID], [CanCreateInvite], [CanKickMembers], [CanBanMembers], [IsAdministrator], [CanManageChannel], [CanManageGuild], [CanAddReaction], [CanViewAudit], [CanViewGuildInsights], [CanViewChannel], [CanSendMessage], [CanSendTTS], [CanManageMessages], [CanSendEmbedLinks], [CanAttachFiles], [CanReadMessagesHistory], [CanMentionEveryOne], [CanUseExternalEmoji], [CanConnect], [CanSpeak], [CanMuteMembers], [CanDefeanMembers], [CanMoveMembers], [CanUseVoiceActivation], [CanPrioritySpeaker], [CanStream], [CanChangeNickName], [CanManageNickName], [CanManageRoles], [CanManageWebHooks], [CanManageEmojisAndStickers], [CanUseApplicationCommands], [CanRequestToSpeak], [CanManageEvents], [CanManageThreads], [CanCreatePublicThreads], [CanCreatePrivateThreads], [CanUseExternalStickers], [CanSendMessagesInThread], [CanStartEmbedActivities], [CanModerateMembers], [CanUseSoundBoard], [CanViewMonetizationAnalytics], [CanSendVoiceMessages]) VALUES (4, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1)
SET IDENTITY_INSERT [dbo].[_DefaultGuildRolesPermissions] OFF
GO
SET IDENTITY_INSERT [dbo].[_DefaultSentMessages] ON 

INSERT [dbo].[_DefaultSentMessages] ([ID], [ChannelID], [MessageID], [Type]) VALUES (4, CAST(1152335161246093372 AS Decimal(20, 0)), CAST(1152892281532194816 AS Decimal(20, 0)), 0)
SET IDENTITY_INSERT [dbo].[_DefaultSentMessages] OFF
GO
SET IDENTITY_INSERT [dbo].[_Giveaway] ON 

INSERT [dbo].[_Giveaway] ([ID], [MessageId], [WinnersCount], [SecondsLeft], [ChannelID]) VALUES (24, CAST(1153414329761280203 AS Decimal(20, 0)), 10, CAST(0 AS Decimal(20, 0)), CAST(1152335354955841616 AS Decimal(20, 0)))
INSERT [dbo].[_Giveaway] ([ID], [MessageId], [WinnersCount], [SecondsLeft], [ChannelID]) VALUES (25, CAST(1276221240885121116 AS Decimal(20, 0)), 10, CAST(0 AS Decimal(20, 0)), CAST(1276215404578078901 AS Decimal(20, 0)))
SET IDENTITY_INSERT [dbo].[_Giveaway] OFF
GO
SET IDENTITY_INSERT [dbo].[_GiveawayRecords] ON 

INSERT [dbo].[_GiveawayRecords] ([ID], [UserID], [IsRewardTaken], [Giveaway_ID], [IsWinner]) VALUES (21, CAST(465972843985764372 AS Decimal(20, 0)), 0, 24, 1)
INSERT [dbo].[_GiveawayRecords] ([ID], [UserID], [IsRewardTaken], [Giveaway_ID], [IsWinner]) VALUES (22, CAST(465972843985764372 AS Decimal(20, 0)), 0, 25, 1)
INSERT [dbo].[_GiveawayRecords] ([ID], [UserID], [IsRewardTaken], [Giveaway_ID], [IsWinner]) VALUES (23, CAST(766745691648819241 AS Decimal(20, 0)), 0, 25, 1)
INSERT [dbo].[_GiveawayRecords] ([ID], [UserID], [IsRewardTaken], [Giveaway_ID], [IsWinner]) VALUES (24, CAST(388008005691768833 AS Decimal(20, 0)), 0, 25, 1)
SET IDENTITY_INSERT [dbo].[_GiveawayRecords] OFF
GO
SET IDENTITY_INSERT [dbo].[_Help] ON 

INSERT [dbo].[_Help] ([ID], [OptionName], [OptionKey], [OptionDescription], [OptionEmote]) VALUES (1, N'Install ⚒️', N'Installation', N'How to install?', NULL)
SET IDENTITY_INSERT [dbo].[_Help] OFF
GO
SET IDENTITY_INSERT [dbo].[_HelpEmbed] ON 

INSERT [dbo].[_HelpEmbed] ([ID], [Message], [EmbedTitle], [EmbedDescription], [ShowDefaultThumbnail], [MentionUser], [Help_ID], [CustomImageUrl]) VALUES (4, N'v1.0.0 BETA', N'Installation', N'1- download beta.rar
\2- restore vanguard.bak database
\3- copy smc folder into your smc folder
\4- inject Smc.dll into SMC_Real.exe
\5- register an account
\6- copy module folder into your server files folder 
\7- copy gameserver folder into your gameserver folder
\8- edit your database data at vanguard/ ini
\9- copy modulekey from smc into Key at vanguard / ini
\10- copy client data
\11- copy clientkey from smc into Key in Settings / settings.ini
\12- inject only vanguard.dll into your sro_client.exe', 0, 1, 1, N'')
SET IDENTITY_INSERT [dbo].[_HelpEmbed] OFF
GO
SET IDENTITY_INSERT [dbo].[_InviteLogger] ON 

INSERT [dbo].[_InviteLogger] ([ID], [InviteCode], [InviterId], [InviterDisplayName], [InvitedId], [InvitedDisplayName]) VALUES (4, N'3sWvGnBVNf', CAST(465972843985764372 AS Decimal(20, 0)), N'bim1337', CAST(653182288019849218 AS Decimal(20, 0)), N'shakedown64')
SET IDENTITY_INSERT [dbo].[_InviteLogger] OFF
GO
SET IDENTITY_INSERT [dbo].[_PollsLogger] ON 

INSERT [dbo].[_PollsLogger] ([ID], [MessageID], [AnswersCount]) VALUES (6, CAST(1152666030758445106 AS Decimal(20, 0)), 3)
INSERT [dbo].[_PollsLogger] ([ID], [MessageID], [AnswersCount]) VALUES (7, CAST(1152977919220650056 AS Decimal(20, 0)), 3)
INSERT [dbo].[_PollsLogger] ([ID], [MessageID], [AnswersCount]) VALUES (8, CAST(1276221810362552350 AS Decimal(20, 0)), 3)
SET IDENTITY_INSERT [dbo].[_PollsLogger] OFF
GO
SET IDENTITY_INSERT [dbo].[_PollsLoggerRecords] ON 

INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (6, CAST(465972843985764372 AS Decimal(20, 0)), N'Heelooo', 6, 1)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (7, CAST(465972843985764372 AS Decimal(20, 0)), N'qdqwd qwd qsd qsd qs', 7, 1)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (8, CAST(465972843985764372 AS Decimal(20, 0)), NULL, 8, 1)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (9, CAST(470878970527612928 AS Decimal(20, 0)), NULL, 8, 1)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (10, CAST(388008005691768833 AS Decimal(20, 0)), NULL, 8, 3)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (11, CAST(538071675489746945 AS Decimal(20, 0)), NULL, 8, 1)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (12, CAST(943156990094503956 AS Decimal(20, 0)), NULL, 8, 1)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (13, CAST(618186400533184519 AS Decimal(20, 0)), NULL, 8, 1)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (14, CAST(342672678857211905 AS Decimal(20, 0)), NULL, 8, 1)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (15, CAST(359160507057307649 AS Decimal(20, 0)), NULL, 8, 1)
INSERT [dbo].[_PollsLoggerRecords] ([ID], [UserID], [Feedback], [Poll_ID], [AnswerID]) VALUES (16, CAST(394154377100787714 AS Decimal(20, 0)), NULL, 8, 1)
SET IDENTITY_INSERT [dbo].[_PollsLoggerRecords] OFF
GO
SET IDENTITY_INSERT [dbo].[_UniqueInformation] ON 

INSERT [dbo].[_UniqueInformation] ([ID], [Name], [ImageUrl], [Emote]) VALUES (1, N'Tiger Woman', N'https://webmall.play-hanami.online/Uniques/1954.png', N'<:tigerwoman:1151988535113552003>')
INSERT [dbo].[_UniqueInformation] ([ID], [Name], [ImageUrl], [Emote]) VALUES (4, N'Uruchi', N'https://webmall.play-hanami.online/Uniques/1982.png', N'<:uruchi:1151987832043348078>')
SET IDENTITY_INSERT [dbo].[_UniqueInformation] OFF
GO
SET IDENTITY_INSERT [dbo].[_UniqueInformationRecords] ON 

INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (2, 1, N'Bimbum', CAST(N'2023-09-14T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (4, 0, N'Bimbum2', CAST(N'2023-08-14T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (5, 0, N'Bimbum3', CAST(N'2023-08-28T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (7, 0, N'Bimbum4', CAST(N'2023-09-14T20:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (8, 0, N'Bimbum5', CAST(N'2023-09-14T00:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (9, 0, N'Bimbum6', CAST(N'2023-09-14T00:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (10, 0, N'Bimbum7', CAST(N'2023-09-14T00:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (11, 0, N'Bimbum8', CAST(N'2023-09-14T00:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (13, 0, N'Bimbum', CAST(N'2023-09-15T08:43:21.9633333' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (14, 1, N'Bimbumlar', CAST(N'2023-09-15T08:52:58.6333333' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (15, 0, N'Bimbumlar', CAST(N'2023-09-15T08:53:11.6700000' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (16, 0, N'Bimbum', CAST(N'2023-09-15T08:53:43.6400000' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (17, 1, N'Bimbum', CAST(N'2023-09-15T08:53:53.9766667' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (18, 0, N'Bimbum', CAST(N'2023-09-15T08:58:12.1833333' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (19, 1, N'Bimbum', CAST(N'2023-09-15T08:58:17.8333333' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (20, 1, N'Bimbum', CAST(N'2023-09-15T08:58:38.2400000' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (21, 0, N'Bimbum', CAST(N'2023-09-15T08:58:43.7666667' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (22, 0, N'Bimbum', CAST(N'2023-09-15T08:58:53.9133333' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (23, 1, N'Bimbum', CAST(N'2023-09-15T08:58:59.0566667' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (24, 1, N'Bimbum', CAST(N'2023-09-15T08:59:17.8266667' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (25, 0, N'Bimbum', CAST(N'2023-09-15T08:59:22.9400000' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (26, 0, N'Bimbum', CAST(N'2024-08-22T18:51:44.7066667' AS DateTime2), 4)
INSERT [dbo].[_UniqueInformationRecords] ([ID], [State], [Killer], [DateTime], [Unique_ID]) VALUES (27, 1, N'', CAST(N'2024-08-22T18:51:57.3666667' AS DateTime2), 4)
SET IDENTITY_INSERT [dbo].[_UniqueInformationRecords] OFF
GO
ALTER TABLE [dbo].[_Giveaway] ADD  DEFAULT ((0.0)) FOR [ChannelID]
GO
ALTER TABLE [dbo].[_GiveawayRecords] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsWinner]
GO
ALTER TABLE [dbo].[_PollsLoggerRecords] ADD  DEFAULT ((0)) FOR [AnswerID]
GO
ALTER TABLE [dbo].[_DefaultGuildCategories]  WITH CHECK ADD  CONSTRAINT [FK_dbo._DefaultGuildCategoriesPermissions._Categories_ID] FOREIGN KEY([Permission_ID])
REFERENCES [dbo].[_DefaultGuildCategoriesPermissions] ([ID])
GO
ALTER TABLE [dbo].[_DefaultGuildCategories] CHECK CONSTRAINT [FK_dbo._DefaultGuildCategoriesPermissions._Categories_ID]
GO
ALTER TABLE [dbo].[_DefaultGuildChannels]  WITH CHECK ADD  CONSTRAINT [FK_dbo._DefaultGuildCategories._Channels_ID] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[_DefaultGuildCategories] ([ID])
GO
ALTER TABLE [dbo].[_DefaultGuildChannels] CHECK CONSTRAINT [FK_dbo._DefaultGuildCategories._Channels_ID]
GO
ALTER TABLE [dbo].[_DefaultGuildRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo._DefaultGuildRolesPermissions._Roles_ID] FOREIGN KEY([Permission_ID])
REFERENCES [dbo].[_DefaultGuildRolesPermissions] ([ID])
GO
ALTER TABLE [dbo].[_DefaultGuildRoles] CHECK CONSTRAINT [FK_dbo._DefaultGuildRolesPermissions._Roles_ID]
GO
ALTER TABLE [dbo].[_GiveawayRecords]  WITH CHECK ADD  CONSTRAINT [FK_dbo._Giveaway._Records_ID] FOREIGN KEY([Giveaway_ID])
REFERENCES [dbo].[_Giveaway] ([ID])
GO
ALTER TABLE [dbo].[_GiveawayRecords] CHECK CONSTRAINT [FK_dbo._Giveaway._Records_ID]
GO
ALTER TABLE [dbo].[_HelpEmbed]  WITH CHECK ADD  CONSTRAINT [FK_dbo._Help._HelpEmbeds_ID] FOREIGN KEY([Help_ID])
REFERENCES [dbo].[_Help] ([ID])
GO
ALTER TABLE [dbo].[_HelpEmbed] CHECK CONSTRAINT [FK_dbo._Help._HelpEmbeds_ID]
GO
ALTER TABLE [dbo].[_HelpMessage]  WITH CHECK ADD  CONSTRAINT [FK_dbo._Help._HelpMessages_ID] FOREIGN KEY([Help_ID])
REFERENCES [dbo].[_Help] ([ID])
GO
ALTER TABLE [dbo].[_HelpMessage] CHECK CONSTRAINT [FK_dbo._Help._HelpMessages_ID]
GO
ALTER TABLE [dbo].[_PollsLoggerRecords]  WITH CHECK ADD  CONSTRAINT [FK_dbo._PollsLogger._Records_ID] FOREIGN KEY([Poll_ID])
REFERENCES [dbo].[_PollsLogger] ([ID])
GO
ALTER TABLE [dbo].[_PollsLoggerRecords] CHECK CONSTRAINT [FK_dbo._PollsLogger._Records_ID]
GO
ALTER TABLE [dbo].[_UniqueInformationRecords]  WITH CHECK ADD  CONSTRAINT [FK_dbo._UniqueInformation._Records_ID] FOREIGN KEY([Unique_ID])
REFERENCES [dbo].[_UniqueInformation] ([ID])
GO
ALTER TABLE [dbo].[_UniqueInformationRecords] CHECK CONSTRAINT [FK_dbo._UniqueInformation._Records_ID]
GO
/****** Object:  StoredProcedure [dbo].[_CreateGiveaway]    Script Date: 10/12/2024 09:28:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_CreateGiveaway]
    @ChannelName NVARCHAR(128),
	@Descr NVARCHAR(2048),
	@SecondsLeft BIGINT,
	@WinnersCount int
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	-- EXEC SRO_VT_BIMBOT.dbo._CreateGiveaway N'🎁┇giveaways', N'10 Lucky winners will win 1000 silk',100,10
    INSERT INTO _DatabaseCommands (Command, Data1, Data2, Data3, Data4) VALUES
								(3, @ChannelName, @Descr, @SecondsLeft, @WinnersCount)
END
GO
/****** Object:  StoredProcedure [dbo].[_CreatePoll]    Script Date: 10/12/2024 09:28:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_CreatePoll]
    @ChannelName NVARCHAR(128),
	@Title NVARCHAR(255),
	@Descr NVARCHAR(2048),
	@AnswersJson NVARCHAR(MAX),
	@ImgUrl VARCHAR(255),
	@MentionEveryone VARCHAR(10)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	-- EXEC SRO_VT_BIMBOT.dbo._CreatePoll N'📑┇vote',N'Poll #1 [2023 - 09 - 16]','Do you love bimbum ?','{"pollbutton_1":{"label":"Agree","emote":"<a:CH_IconVoteYes:711765210607779872>"},"pollbutton_2":{"label":"Disagree","emote":"<a:CH_IconVoteNo:711765230857748521>"},"pollbutton_3":{"label":"Dont Care","emote":"<a:CH_IconTyping:715584469553119254>"}}','https://cdn0.iconfinder.com/data/icons/content-volume-2/24/poll-512.png','true'
    INSERT INTO _DatabaseCommands (Command, Data1, Data2, Data3, Data4, Data5, Data6) VALUES
								(2, @ChannelName, @Title, @Descr, @AnswersJson, @ImgUrl, @MentionEveryone)
END
GO
/****** Object:  StoredProcedure [dbo].[_GetPlayerStatus]    Script Date: 10/12/2024 09:28:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_GetPlayerStatus]
	@CharName NVARCHAR(64),
	@RetnParam INT OUTPUT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	--	SET @RetnParam = 0;--Offline
	SET @RetnParam = 1;--Online
END
GO
/****** Object:  StoredProcedure [dbo].[_Logger_SendGlobal]    Script Date: 10/12/2024 09:28:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_Logger_SendGlobal]
	@PlayerName NVARCHAR(30),
	@Message NVARCHAR(255)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	DECLARE @ChannelName NVARCHAR(128) = N'spam';

	IF(LOWER(@Message) LIKE '%wts%' OR LOWER(@Message) LIKE '%wtb%' OR LOWER(@Message) LIKE '%wtt%')
	BEGIN
		SET @ChannelName = N'📑┇market-globals';
	END

    EXEC _SendEmbedMessage @ChannelName, '', 'false', @PlayerName, @Message, 15158332, '','https://cdn.discordapp.com/emojis/1152126878916825099.png';
END
GO
/****** Object:  StoredProcedure [dbo].[_Logger_SendUnique]    Script Date: 10/12/2024 09:28:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_Logger_SendUnique]
    @UniqueName NVARCHAR(255),
	@Killer NVARCHAR(30),
	@State BIT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	--EXEC _Logger_SendUnique 'Uruchi', 'Bimbum' , 0 --KILL
	--EXEC _Logger_SendUnique 'Uruchi', '' , 1 --SPAWN

	DECLARE @ReferenceID INT,
			@ImgURL VARCHAR(512)

	SELECT @ReferenceID = ID, @ImgURL = ImageUrl FROM _UniqueInformation WHERE [NAME] LIKE @UniqueName;

	IF @@ROWCOUNT > 0
	BEGIN
		INSERT INTO _UniqueInformationRecords VALUES (@State, @Killer, GETDATE(), @ReferenceID);

		DECLARE @Descr NVARCHAR(128);

		IF(@State = 1)
		BEGIN
			SET @Descr = N' Has spawned ✔️'
		END
		ELSE
		BEGIN
			SET @Descr = CONCAT(N' Was killed by ', @Killer, N' ❌')
		END

		EXEC _SendEmbedMessage N'spam', '', 'false', @UniqueName, @Descr, 15158332, '',@ImgURL;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[_SendEmbedMessage]    Script Date: 10/12/2024 09:28:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_SendEmbedMessage]
    @ChannelName NVARCHAR(128),
	@Message NVARCHAR(2048),
	@MentionEveryone NVARCHAR(10),
	@EmbedTitle NVARCHAR(255),
	@EmbedDescription NVARCHAR(MAX),
	@EmbedColor INT,
	@EmbedImageUrl VARCHAR(512),
	@EmbedThumbnailUrl VARCHAR(512)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	-- @ChannelName: 📢┇announcements
	-- @Message: Hello World
	-- @MentionEveryone: true

	-- EXEC SRO_VT_BIMBOT.dbo._SendEmbedMessage N'💬┇public-chat',N'Hello World','true',N'Title', N'Description',15158332,'','https://play-lh.googleusercontent.com/q33zAX4Zb9BD_QJsb87CUlHtjo86ZtdAla-GHqXIuALHrt_bnqqx2O3YBMsubNoc1854';

    INSERT INTO _DatabaseCommands (Command, Data1, Data2, Data3, Data4, Data5, Data6, Data7, Data8) VALUES
								(1, @ChannelName, @Message, @MentionEveryone, @EmbedTitle, @EmbedDescription, @EmbedColor, @EmbedImageUrl, @EmbedThumbnailUrl)
END
GO
/****** Object:  StoredProcedure [dbo].[_SendMessage]    Script Date: 10/12/2024 09:28:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_SendMessage]
    @ChannelName NVARCHAR(128),
	@Message NVARCHAR(2048),
	@MentionEveryone NVARCHAR(10)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

	-- @ChannelName: 📢┇announcements
	-- @Message: Hello World
	-- @MentionEveryone: true

	-- EXEC SRO_VT_BIMBOT.dbo.SendMessage N'💬┇public-chat',N'Hello World','true'

    INSERT INTO _DatabaseCommands (Command, Data1, Data2, Data3) VALUES
								(0, @ChannelName, @Message, @MentionEveryone)
END
GO
