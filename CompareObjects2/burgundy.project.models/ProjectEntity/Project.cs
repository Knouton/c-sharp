using System;
using System.Collections.Generic;
using Burgundy.Longread.Models;
using Burgundy.Project.Models.Geograffee;
using Burgundy.Project.Models.Types;
using Burgundy.Shared.Models.Contents;
using Burgundy.Shared.Models.Types;
using Burgundy.Shared.Models.Types.Enums;
using Burgundy.Tag.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;
using Point = Burgundy.Project.Models.ProjectEntity.Point;

namespace Burgundy.Project.Models.ProjectEntity
{
    [BsonIgnoreExtraElements]
    [TsClass(AutoExportMethods = false)]
    public class Project : ICloneable
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }
        public string ProjectId { get; set; }
        public ProjectStatus Status { get; set; }
        public bool IsVerified { get; set; }
        public bool IsActive { get; set; }

        [Obsolete]
        public string Course { get; set; } = string.Empty;
        public List<FileContent> TitleImages { get; set; } = new List<FileContent>();
        public List<FileContent> Files { get; set; } = new List<FileContent>();

        public List<NameObject> Title { get; set; } = new List<NameObject>();
        public List<NameObject> About { get; set; } = new List<NameObject>();
        public DateTime Created { get; set; }
        public DateTime Published { get; set; }
        public DateTime Edited { get; set; }

        [Obsolete]
        public int Year { get; set; }
        public string PointName { get; set; } = string.Empty;

        public string TeamId { get; set; } = string.Empty;
        public string PointId { get; set; } = string.Empty;
        public string SeasonId { get; set; } = string.Empty;
        public string CompetitionId { get; set; } = string.Empty;
        public string LongreadId { get; set; } = string.Empty;
        public string ProjectIdExternalSystem { get; set; } = string.Empty;



        public string CreatorId { get; set; } = string.Empty;
        public List<string> AuthorIds { get; set; } = new List<string>();
        public List<string> CuratorsIdList { get; set; } = new List<string>();

        [Obsolete] public string CuratorId { get; set; }
        public string CategoryID { get; set; } = string.Empty;
        public string CardId { get; set; } = string.Empty;
        public List<string> TagsID { get; set; } = new List<string>();
        [Obsolete] public string MasterTagID { get; set; } = string.Empty;

        public List<string> PostIds { get; set; } = new List<string>();

        /// <summary>
        /// Список одобрений
        /// </summary>
        public List<Approve> Approvals { get; set; } = new List<Approve>();

        /// <summary>
        /// Автор проекта. Студент, модератор, препод.
        /// Нужно, чтобы понимать что делать с проектом дальше
        /// </summary>
        public ProjectProducerEnum ProjectProducer { get; set; } = ProjectProducerEnum.Default;

        public string Service { get; set; }

        public Dictionary<string, string> additionalInfo { get; set;  } = new Dictionary<string, string>();    
        
        public List<string> Contexts { get; set; }
        public List<string> Services { get; set; }

        [BsonIgnore]
        public Team Team { get; set; } = new Team();

        [BsonIgnore]
        public Season Season { get; set; } = new Season();

        [BsonIgnore]
        public Point Point { get; set; } = new Point();

        [BsonIgnore]
        public List<Designer> Authors { get; set; } = new List<Designer>();

        [BsonIgnore]
        public List<Post> Posts { get; set; } = new List<Post>();

        [BsonIgnore]
        public List<Designer> Curators { get; set; }

        [BsonIgnore]
        public List<NameObject> CategoryName { get; set; } = new List<NameObject>();

        /// <summary>
        /// Категория представляет из себя сущность тега.
        /// </summary>
        [BsonIgnore]
        public Tag.Models.Tag Category { get; set; } = new Tag.Models.Tag();


        [BsonIgnore]
        public List<Tag.Models.Tag> Tags { get; set; } = new List<Tag.Models.Tag>();
        
        [Obsolete]
        [BsonIgnore]
        public Tag.Models.Tag MasterTag { get; set; } = new Tag.Models.Tag();

        [BsonIgnore]
        public List<List<NameObject>> TagsName { get; set; } = new List<List<NameObject>>();
        
        [Obsolete]
        [BsonIgnore]
        public List<NameObject> MasterTagName { get; set; } = new List<NameObject>();

        [BsonIgnore]
        public Longread.Models.Longread Longread { get; set; } = new Longread.Models.Longread();

        //Количество лайков
        [BsonIgnore]
        public int QuCount { get; set; }

        //Есть ли лайк от текущего пользователя
        [BsonIgnore]
        public bool isQu { get; set; } = false;

        [BsonIgnore]
        public bool isBookmark { get; set; } = false;
        
        [BsonIgnore] 
        public List<Vote> UserVotes { get; set; }
        
        [BsonIgnore] 
        public List<JuryVote> JuryVotes { get; set; }
        
        [BsonIgnore] 
        public Designer Creator { get; set; }
        
        

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
