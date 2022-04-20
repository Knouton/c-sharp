using System.Collections.Generic;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.ProjectEntity
{    
    [BsonIgnoreExtraElements]
    [TsClass]

    public class Point
    {

        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }
        public string PointId { get; set; }

        /// <summary>
        /// Единый Идентификатор страны для сведения
        /// </summary>
        public string CountryId { get; set; } = string.Empty;
        public List<NameObject> Name { get; set; } = new List<NameObject>();
        public List<NameObject> City { get; set; } = new List<NameObject>();
        public List<NameObject> Country { get; set; } = new List<NameObject>();
       

        public double Longitude { get; set; }

        public double Latitude { get; set; }
    }
}
