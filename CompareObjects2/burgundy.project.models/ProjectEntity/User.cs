using Burgundy.Shared.Models.Contents;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgundy.Project.Models.ProjectEntity
{
    [TsClass]
    [BsonIgnoreExtraElements]
    public class User
    {

        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }
       
        public string ProfileId { get; set; }

        public string Context { get; set; }
        public string ContextEntityId { get; set; }

        /// <summary>
        /// Роли. Учитель, студент и тд
        /// </summary>
        public string GlobalType { get; set; }

        public List<FileContent> Avatar { get; set; }

        public List<string> AvatarHistory { get; set; }

        public List<NameObject> About { get; set; } = new List<NameObject>() { new NameObject() { Lang = "ru", Name = "" }, new NameObject() { Lang = "en", Name = "" } };


        public List<NameObject> NameCaсhe { get; set; }

        public string NickName { get; set; }


        public DateTime Created { get; set; }

        public DateTime Edited { get; set; }

        public List<NameObject> Name { get; set; } = new List<NameObject>();
        public List<NameObject> SurName { get; set; } = new List<NameObject>();
        public List<SocialNetwork> SocialNetworks { get; set; } = new List<SocialNetwork>();

        public List<StudyOrWorkPlace> Education { get; set; } = new List<StudyOrWorkPlace>();

        public List<StudyOrWorkPlace> WorkPlaces { get; set; } = new List<StudyOrWorkPlace>();

        public List<NameObject> Biography { get; set; } = new List<NameObject>()
            {new NameObject() {Lang = "ru", Name = ""}, new NameObject() {Lang = "en", Name = ""}};
        public List<NameObject> Company { get; set; } = new List<NameObject>()
            {new NameObject() {Lang = "ru", Name = ""}, new NameObject() {Lang = "en", Name = ""}};

        public List<NameObject> Position { get; set; } = new List<NameObject>()
            {new NameObject() {Lang = "ru", Name = ""}, new NameObject() {Lang = "en", Name = ""}};


        public CountryModel Country { get; set; } = new CountryModel("", "", "", "");


        public List<string> RolesList { get; set; } = new List<string>();


        /// <summary>
        /// ID конкурса которые имеет права судить данный жюри
        /// </summary>
        public List<string> JuryCompetitionID { get; set; }



    }
}
