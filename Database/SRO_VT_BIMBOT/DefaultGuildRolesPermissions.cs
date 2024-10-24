namespace BimBot.Database.SRO_VT_BIMBOT
{
    public class DefaultGuildRolesPermissions
    {
        public int ID { get; set; }
        public bool CanCreateInvite { get; set; }
        public bool CanKickMembers { get; set; }
        public bool CanBanMembers { get; set; }
        public bool IsAdministrator { get; set; }
        public bool CanManageChannel { get; set; }
        public bool CanManageGuild { get; set; }
        public bool CanAddReaction { get; set; }
        public bool CanViewAudit { get; set; }
        public bool CanViewGuildInsights { get; set; }
        public bool CanViewChannel { get; set; }
        public bool CanSendMessage { get; set; }
        public bool CanSendTTS { get; set; }
        public bool CanManageMessages { get; set; }
        public bool CanSendEmbedLinks { get; set; }
        public bool CanAttachFiles { get; set; }
        public bool CanReadMessagesHistory { get; set; }
        public bool CanMentionEveryOne { get; set; }
        public bool CanUseExternalEmoji { get; set; }
        public bool CanConnect { get; set; }
        public bool CanSpeak { get; set; }
        public bool CanMuteMembers { get; set; }
        public bool CanDefeanMembers { get; set; }
        public bool CanMoveMembers { get; set; }
        public bool CanUseVoiceActivation { get; set; }
        public bool CanPrioritySpeaker { get; set; }
        public bool CanStream { get; set; }
        public bool CanChangeNickName { get; set; }
        public bool CanManageNickName { get; set; }
        public bool CanManageRoles { get; set; }
        public bool CanManageWebHooks { get; set; }
        public bool CanManageEmojisAndStickers { get; set; }
        public bool CanUseApplicationCommands { get; set; }
        public bool CanRequestToSpeak { get; set; }
        public bool CanManageEvents { get; set; }
        public bool CanManageThreads { get; set; }
        public bool CanCreatePublicThreads { get; set; }
        public bool CanCreatePrivateThreads { get; set; }
        public bool CanUseExternalStickers { get; set; }
        public bool CanSendMessagesInThread { get; set; }
        public bool CanStartEmbedActivities { get; set; }
        public bool CanModerateMembers { get; set; }
        public bool CanUseSoundBoard { get; set; }
        public bool CanViewMonetizationAnalytics { get; set; }
        public bool CanSendVoiceMessages { get; set; }
        public virtual ICollection<DefaultGuildRoles> Roles { get; set; } = new List<DefaultGuildRoles>();
    }


}
