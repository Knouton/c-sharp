using System;
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

    public class Team
    {
   
        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }
        public string TeamId { get; set; }

        public List<NameObject> Name { get; set; } = new List<NameObject>();
        public string PointId { get; set; } 

        [BsonIgnore]
        public Point Point { get; set; } = new Point();
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// Дата последнего редактирвания
        /// </summary>
        public DateTime Edited { get; set; }
    }
}
