using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.FrontendModels
{
    [TsClass]
    public class JuryVoteModel
    {
        public string VoteCriteriaId { get; set; }
        public int VoteValue { get; set; }

        public JuryVoteModel(string voteCriteriaId, int voteValue)
        {
            VoteCriteriaId = voteCriteriaId;
            VoteValue = voteValue;
        }
    }
}