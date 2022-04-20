using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Types
{
    [TsEnum]
    public enum CompetitionStatus
    {
        Draft,
        Announcement,
        Open,
        Voting,
        Summarizing,
        Completed,
        Archived,
        Deleted,
    }
}