using System.Collections.Generic;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson.Serialization.Attributes;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    [BsonIgnoreExtraElements]

    [TsClass]

    public class RewardInfo
    {
        public bool IsReward { get; set; }

        public List<NameObject> RewardDescription { get; set; }

        public List<NameObject> RewardText { get; set; }

        public List<NameObject> RewardName { get; set; }
        
        public int RewardsCount { get; set; }

        public RewardInfo()
        {
            IsReward = false;
            RewardDescription = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            RewardText = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            RewardName = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            RewardsCount = 0;
        }

    }
}
