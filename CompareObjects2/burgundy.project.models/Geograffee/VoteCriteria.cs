using System.Collections.Generic;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    [BsonIgnoreExtraElements]
    [TsClass]
    public class VoteCriteria
    {
        [JsonIgnore] [BsonId] 
        public ObjectId InternalId { get; set; }
        public string VoteCriteriaId { get; set; }

        public List<NameObject> Name { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Weight { get; set; }

        public VoteCriteria()
        {
            Name = new List<NameObject>()
                {new NameObject {Lang = "ru", Name = ""}, new NameObject {Lang = "en", Name = ""}};
            MinValue = 0;
            MaxValue = 10;
            Weight = 1;
        }
    }
}