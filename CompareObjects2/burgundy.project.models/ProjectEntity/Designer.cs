using System;
using System.Collections.Generic;
using Burgundy.Shared.Models.Contents;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.ProjectEntity
{

    [TsClass]
    [BsonIgnoreExtraElements]
    public class Designer
    {
   
        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }
        /// <summary>
        /// Иденнтификатор дизайнера
        /// </summary>
        public string DesignerId { get; set; }
        
        public string ProfileId { get; set; }

        public string Context { get; set; }
        public string ContextEntityId { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string AccountId { get; set; }


        /// <summary>
        /// Роли. Учитель, студент и тд
        /// </summary>
        public string GlobalType { get; set; }
    
        public List<FileContent> Avatar { get; set; }

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
        public List<string> CompetitionID { get; set; }


        /// <summary>
        /// ID конкурса которые имеет права судить данный жюри
        /// </summary>
        public List<string> JuryCompetitionID { get; set; }
        /// <summary>
        /// Id тегов преподавателя
        /// </summary>
        public List<string> TagListId { get; set; } = new List<string>();

        /// <summary>
        /// Объекты тегов преподавателя
        /// </summary>
        [BsonIgnore]
        public List<Tag.Models.Tag> Tags { get; set; } = new List<Tag.Models.Tag>();

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool IsEmployee()
        {
            return Equals(GlobalType, "Employee") || Equals(GlobalType, "HseDesignEmployee");
        }
        
        public bool IsStudent()
        {
            return Equals(GlobalType, "Student") || Equals(GlobalType, "HseDesignStudent");
        }

        public bool IsLaboratoryEmployee()
        {
            return IsEmployee() && RolesList != null && RolesList.Contains("HseDesignLaboratoryEmployee");
        }

    }
}
