using System;
using System.Collections.Generic;

namespace BimBot.Database.SILKROAD_R_ACCOUNT;

public partial class WebVoteMain
{
    public int Idx { get; set; }

    public int? GroupNum { get; set; }

    public string? SubjectUs { get; set; }

    public string? SubjectDe { get; set; }

    public string? SubjectTr { get; set; }

    public string? SubjectEs { get; set; }

    public string? SubjectEg { get; set; }

    public string? SynopsisUs { get; set; }

    public string? SynopsisDe { get; set; }

    public string? SynopsisTr { get; set; }

    public string? SynopsisEs { get; set; }

    public string? SynopsisEg { get; set; }

    public string? MessageUs { get; set; }

    public string? MessageDe { get; set; }

    public string? MessageTr { get; set; }

    public string? MessageEs { get; set; }

    public string? MessageEg { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime RegDate { get; set; }

    public byte? Active { get; set; }
}
