using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebVoteQuestion
{
    public int Idx { get; set; }

    public int PollNum { get; set; }

    public string QuestionUs { get; set; } = null!;

    public string QuestionDe { get; set; } = null!;

    public string QuestionTr { get; set; } = null!;

    public string QuestionEs { get; set; } = null!;

    public string QuestionEg { get; set; } = null!;
}
