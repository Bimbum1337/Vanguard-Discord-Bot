using Discord;

namespace BimBot.Database.SRO_VT_BIMBOT
{
    public partial class DefaultGuildCategoriesPermissions
    {
        public int ID { get; set; }
        public PermValue CanCreateInvite { get; set; }
        public PermValue CanManageChannel { get; set; }
        public PermValue CanAddReaction { get; set; }
        public PermValue CanViewChannel { get; set; }
        public PermValue CanSendMessage { get; set; }
        public PermValue CanSendTTS { get; set; }
        public PermValue CanManageMessages { get; set; }
        public PermValue CanSendEmbedLinks { get; set; }
        public PermValue CanAttachFiles { get; set; }
        public PermValue CanReadMessagesHistory { get; set; }
        public PermValue CanMentionEveryOne { get; set; }
        public PermValue CanUseExternalEmoji { get; set; }
        public PermValue CanConnect { get; set; }
        public PermValue CanSpeak { get; set; }
        public PermValue CanMuteMembers { get; set; }
        public PermValue CanDefeanMembers { get; set; }
        public PermValue CanMoveMembers { get; set; }
        public PermValue CanUseVoiceActivation { get; set; }
        public PermValue CanManageRoles { get; set; }
        public PermValue CanManageWebHooks { get; set; }
        public PermValue CanPrioritySpeaker { get; set; }
        public PermValue CanStream { get; set; }
        public PermValue CanUseSlashCommands { get; set; }
        public PermValue CanUseApplicationCommands { get; set; }
        public PermValue CanRequestToSpeak { get; set; }
        public PermValue CanManageThreads { get; set; }
        public PermValue CanCreatePublicThreads { get; set; }
        public PermValue CanCreatePrivateThreads { get; set; }
        public PermValue CanUsePublicThreads { get; set; }
        public PermValue CanUsePrivateThreads { get; set; }
        public PermValue CanUseExternalStickers { get; set; }
        public PermValue CanSendMessagesInThread { get; set; }
        public PermValue CanStartEmbedActivities { get; set; }
        public virtual ICollection<DefaultGuildCategories> Categories { get; set; } = new List<DefaultGuildCategories>();

    }
}
