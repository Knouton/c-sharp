using Burgundy.Project.Models.Types;
using MongoDB.Bson.Serialization.Attributes;
using Reinforced.Typings.Attributes;
using System;

namespace Burgundy.Project.Models.Geograffee
{
    [BsonIgnoreExtraElements]
    [TsClass]
    public class Vote : ICloneable
    {
        public string CompetitionId { get; set; } = string.Empty;
        public string NominationId { get; set; } = string.Empty;
        public string ProjectId { get; set; } = string.Empty;
        public SeasonStageEnum SeasonStageEnum { get; set; }
        public string ProfileId { get; set; } = string.Empty;
        public string ProfileEmail { get; set; } = string.Empty;

        public Vote(string competitionId, string nominationId, string projectId, SeasonStageEnum seasonStageEnum, string profileId, string profileEmail)
        {
            CompetitionId = competitionId;
            NominationId = nominationId;
            ProjectId = projectId;
            SeasonStageEnum = seasonStageEnum;
            ProfileId = profileId;
            ProfileEmail = profileEmail;
        }

        public Vote()
        {
            
        }

        public bool Equals(Vote obj2)
        {
            return Equals(this, obj2);
        }

        public static bool Equals(Vote obj1, Vote obj2)
        {
            return Equals(obj1.CompetitionId, obj2.CompetitionId)
                   && Equals(obj1.NominationId, obj2.NominationId)
                   && Equals(obj1.ProjectId, obj2.ProjectId)
                   && obj1.SeasonStageEnum == obj2.SeasonStageEnum
                   && Equals(obj1.ProfileId, obj2.ProfileId);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}