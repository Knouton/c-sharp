using System.Collections.Generic;
using Burgundy.Project.Models.ProjectEntity;
using MongoDB.Bson.Serialization.Attributes;

namespace Burgundy.Project.Models.Opa
{
    /// <summary>
    /// Пользователь для рейтинга ОПА 
    /// </summary>
    [BsonIgnoreExtraElements]
    public class OpaUser
    {
        /// <summary>
        /// Идентификатор Акаунта
        /// </summary>
        public string AccountId { get; set; }
        /// <summary>
        /// Идентификатор профайла
        /// </summary>
        public string ProfileId { get; set; }
        /// <summary>
        /// Идентификатор проекта внешней системы
        /// </summary>
        public string ProfileIdExternalSystem { get; set; } = string.Empty;
        /// <summary>
        /// Тип пользователя
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Контекст
        /// </summary>
        public string Context { get; set; }
        /// <summary>
        /// Тип контекста
        /// </summary>
        public string ContextEntityId { get; set; }
        /// <summary>
        /// Идентификаторы проектов
        /// </summary>
        public List<string> ProjectIds { get; set; }
        /// <summary>
        /// Проекты
        /// </summary>
        public List<OpaProject> Projects { get; set; }
        /// <summary>
        /// Суммарный итоговый рейтинг
        /// </summary>
        public float FinalRating { get; set; }
        /// <summary>
        /// Суммарный потенциальный рейтинг
        /// </summary>
        public float PotentialRating { get; set; }
        /// <summary>
        /// Полная информация по рейтингу
        /// </summary>
        public List<ActivityRating> Ratings { get; set; }
        
        [BsonIgnore]
        public Designer User { get; set; } = new Designer();

    }
}