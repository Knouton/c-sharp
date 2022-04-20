using System.Collections.Generic;
using Burgundy.Project.Models.ProjectEntity;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson.Serialization.Attributes;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    [BsonIgnoreExtraElements]
    [TsClass]

    public class CompetitionInfo
    {
        public List<NameObject> AboutText { get; set; }
        public List<NameObject> ParticipantsText { get; set; }
        public List<NameObject> JuryText { get; set; }
        public List<NameObject> RulesText { get; set; }

        /// <summary>
        /// Награда
        /// </summary>
        public RewardInfo RewardInfo { get; set; }

        /// <summary>
        /// Оценивание проектов
        /// </summary>
        public List<NameObject> EvaluationText { get; set; }

        public string SeasonID { get; set; }

        [BsonIgnore]
        public Season Season { get; set; }

        public CompetitionInfo()
        {
            AboutText = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } }; 
            ParticipantsText = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            JuryText = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            RulesText = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            RewardInfo = new RewardInfo();
            EvaluationText = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            SeasonID = string.Empty;
            Season = new Season();
        }

        
    }
}