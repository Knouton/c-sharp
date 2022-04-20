using System.Collections.Generic;
using Burgundy.Project.Models.Geograffee;
using Burgundy.Project.Models.Opa;

namespace Burgundy.Project.Models
{
    /// <summary>
    /// Подготовленные данные по рейтингу ОПА
    /// </summary>
    public class ActivityRating
    {
        /// <summary>
        /// Аккаунт пользователя
        /// </summary>
        public string AccountId { get; set; }
        /// <summary>
        /// Профиль пользователя
        /// </summary>
        public string ProfileId { get; set; }
        /// <summary>
        /// Тип активности
        /// </summary>
        public ActivityType Type { get; set; }
        /// <summary>
        /// Контекст
        /// </summary>
        public string Context { get; set; }
        /// <summary>
        /// Тип контекста
        /// </summary>
        public string ContextEntityId { get; set; }
        /// <summary>
        /// Рейтинг активности по типу активности
        /// </summary>
        public float RatingSum { get; set; }
        /// <summary>
        /// Потенциальный рейтинг активности
        /// </summary>
        public float PotentialRatingSum { get; set; }
        /// <summary>
        /// Проекты повлиявшие на рейтинг
        /// </summary>
        public List<string> ProjectsIds { get; set; }

    }
}