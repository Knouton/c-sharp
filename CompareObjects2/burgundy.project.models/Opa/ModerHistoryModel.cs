using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Opa
{
    /// <summary>
    /// Хранит в себе историю модерации
    /// </summary>
    [TsClass]
    [BsonIgnoreExtraElements]
    public class ModerHistoryModel
    {
        [JsonIgnore]
        [BsonId]
        public ObjectId InternalId { get; set; }    
        
        public string AccountId { get; set; }
        
        /// <summary>
        /// Количество поставленных лайков
        /// </summary>
        public int LikeCount { get; set; }
        
        /// <summary>
        /// Количество опубликованных проектов
        /// </summary>
        public int ProjectCount { get; set; }
        
        /// <summary>
        /// Количество тегов за которые он отвечает
        /// </summary>
        public int OwnerTagCount { get; set; }
        
        /// <summary>
        /// Количество отмодерированных проектов
        /// Учитываются и отправка на публикацию и в черновик
        /// </summary>
        public List<ModeratedProject> ModeratedProjects { get; set; }

        /// <summary>
        /// Количество проектов где препод является куратором
        /// </summary>
        public int CuratorProjectCount { get; set; }
        
        /// <summary>
        /// Количество оценок в конкурсах
        /// Пока не активно
        /// </summary>
        public int CompetitionCount { get; set; }
    }
    
    
}