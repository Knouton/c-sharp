using System;
using System.Collections.Generic;
using Burgundy.Project.Models.Types;
using Burgundy.Shared.Models.Contents;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    [TsClass]
    [BsonIgnoreExtraElements]
    public class Competition : ICloneable
    {
        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }
        public string CompetitionId { get; set; }

        /// <summary>
        /// Telling Stories Cup
        /// </summary>
        public List<NameObject> Name { get; set; } = new List<NameObject>();

        public CompetitionStatus Status { get; set; }
        
        public List<string> Contexts { get; set; } = new List<string>();
        public List<string> Services { get; set; } = new List<string>();
        
        /// <summary>
        /// Международный студ конкурс
        /// </summary>
        public List<NameObject> Title { get; set; } = new List<NameObject>();
        public List<NameObject> TitleDescription { get; set; } = new List<NameObject>();
        
        public List<FileContent> TitleImages { get; set; } = new List<FileContent>();
        public CompetitionInfo CompetitionInfo { get; set; } = new CompetitionInfo();
        
        public CompetitionColorTheme CompetitionColorTheme { get; set; } = new CompetitionColorTheme();

        public CompetitionContacts CompetitionContacts { get; set; } = new CompetitionContacts();
        
        public List<string> AdministratorID { get; set; } = new List<string>();
        public List<string> ModeratorID { get; set; } = new List<string>();
        public List<string> JuryID { get; set; } = new List<string>();

        public List<string> NominationsID { get; set; } = new List<string>();

        [BsonIgnore]
        public List<Nomination> Nominations { get; set; } = new List<Nomination>();


        public Competition()
        {
            Name = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            Status = CompetitionStatus.Draft;
            Contexts = new List<string>();
            Services = new List<string>();
            Title = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            TitleDescription = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            TitleImages = new List<FileContent>();
            CompetitionInfo = new CompetitionInfo();
            CompetitionColorTheme = new CompetitionColorTheme();
            CompetitionContacts = new CompetitionContacts();
            AdministratorID = new List<string>();
            ModeratorID = new List<string>();
            JuryID = new List<string>();
            NominationsID = new List<string>();
            Nominations = new List<Nomination>();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }


}
