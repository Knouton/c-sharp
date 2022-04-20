using System;
using System.Collections.Generic;
using Burgundy.Project.Models.Geograffee;
using Burgundy.Shared.Models.Contents;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.ProjectEntity
{
    [BsonIgnoreExtraElements]
    [TsClass]
    public class Season : ICloneable
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }
        public string SeasonId { get; set; }
        public List<NameObject> Name { get; set; }
        public List<NameObject> Description { get; set; }
        public List<NameObject> About { get; set; }

        public FileContent TitleImage { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public List<SeasonStage> SeasonStages { get; set; }

        public Season()
        {
            Name = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            Description = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            About = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            StartDateTime = DateTime.MinValue;
            EndDateTime = DateTime.MinValue;
            SeasonStages = new List<SeasonStage>() { new SeasonStage(), new SeasonStage(), new SeasonStage(), new SeasonStage() };
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
