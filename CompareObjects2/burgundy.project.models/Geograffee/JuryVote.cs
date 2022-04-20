using Burgundy.Project.Models.Types;
using MongoDB.Bson.Serialization.Attributes;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    [BsonIgnoreExtraElements]
    [TsClass]
    public class JuryVote : Vote
    {
        public string VoteCriteriaId { get; set; } = string.Empty;
        public int VoteValue { get; set; } = -1;

        public JuryVote(string competitionId, string nominationId, string projectId, SeasonStageEnum seasonStageEnum, string profileId, string profileEmail, string voteCriteriaId, int voteValue) 
            : base(competitionId, nominationId, projectId, seasonStageEnum, profileId, profileEmail)
        {
            VoteCriteriaId = voteCriteriaId;
            VoteValue = voteValue;
        }

        public JuryVote() : base()
        {
            
        }
        
        public bool Equals(JuryVote obj2)
        {
            return Equals(this, obj2);
        }

        public static bool Equals(JuryVote obj1, JuryVote obj2)
        {
            return Vote.Equals(obj1, obj2)
                   && Equals(obj1.VoteCriteriaId, obj2.VoteCriteriaId);
        }
    }
}