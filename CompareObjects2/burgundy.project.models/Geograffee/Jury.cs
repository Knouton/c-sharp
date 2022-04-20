using System;
using System.Collections.Generic;
using Burgundy.Project.Models.ProjectEntity;
using Burgundy.Shared.Models.Contents;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    [BsonIgnoreExtraElements]
    [TsClass]

    public class Jury : Designer, ICloneable
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public string JuryId { get; set; }

        /// <summary>
        /// ID конкурса которые имеет права судить данный жюри
        /// </summary>
        public List<string> CompetitionID { get; set; }

        /// <summary>
        /// Биография
        /// </summary>
        public List<NameObject> Biography { get; set; } = new List<NameObject>()
            {new NameObject() {Lang = "ru", Name = ""}, new NameObject() {Lang = "en", Name = ""}};

        /// <summary>
        /// Компания
        /// </summary>
        public List<NameObject> Company { get; set; } = new List<NameObject>()
            {new NameObject() {Lang = "ru", Name = ""}, new NameObject() {Lang = "en", Name = ""}};

        /// <summary>
        /// Должность
        /// </summary>
        public List<NameObject> Position { get; set; } = new List<NameObject>()
            {new NameObject() {Lang = "ru", Name = ""}, new NameObject() {Lang = "en", Name = ""}};

        /// <summary>
        /// Страна
        /// </summary>
        public CountryModel Country { get; set; } = new CountryModel("", "", "", "");




        public Jury(Designer designer) 
        {
            JuryId = designer.AccountId;
            Name = designer.Name;
            SurName = designer.SurName;
            SocialNetworks = designer.SocialNetworks;
            WorkPlaces = designer.WorkPlaces;
            Education = designer.WorkPlaces;
        }


        public Jury()
        {

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
