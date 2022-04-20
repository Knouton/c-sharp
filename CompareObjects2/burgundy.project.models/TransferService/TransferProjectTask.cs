using System;
using System.Collections.Generic;
using Burgundy.Geography.Models.TransferModels.AutoGenerate;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Burgundy.Project.Models.Geograffee
{
    [BsonIgnoreExtraElements]
    public class TransferProjectTask
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }
        public string TaskId { get; set; }
        public DateTime DateCreate { get; set; }
        public string Status { get; set; }
        public string ProjectId { get; set; }
        [Obsolete]
        public string ProjectExternalSystemId { get; set; }
        public string ProjectIdExternalSystem { get; set; }
        public List<string> Authors { get; set; } = new List<string>();
        public List<string> Curators { get; set; } = new List<string>();
        public List<string> AuthorsExternalSystem { get; set; } = new List<string>();
        public List<string> CuratorsExternalSytem { get; set; } = new List<string>();
        public string UrlTitleImageExternalSystem { get; set; }
        public List<string> UrlImagesExternalSystem { get; set; }
        public string DesignerId { get; set; }
        public string UserId { get; set; }
        public string LongreadId { get; set; }
        public List<string> PostIds { get; set; } = new List<string>();
        public List<string> FileIds { get; set; } = new List<string>();
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string DynamicDataString { get; set; }
        [BsonIgnore]
        public UserProject UserProject { get; set; }
        
    }
}