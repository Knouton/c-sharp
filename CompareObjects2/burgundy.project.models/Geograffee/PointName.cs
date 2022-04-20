using System.Collections.Generic;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    /// <summary>
    /// Хранит в себе словарь названии геопозиции для проектов
    /// </summary>
    [BsonIgnoreExtraElements]
    [TsClass]

    public class PointName
    {
        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }

        public string ProjectId { get; set; }

        public string PointId { get; set; }

        public List<NameObject> Name { get; set; }


    }
}
