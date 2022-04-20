using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{

    /// <summary>
    /// Для определения типа ОПА активности
    /// </summary>
    public enum ActivityType
    {
        /// <summary>
        /// Собственные проекты Author
        /// </summary>
        SelfActivity = 1,

        /// <summary>
        /// Курируемые проекты Curator
        /// </summary>
        SupervisedActivity = 2,

        /// <summary>
        /// Медиа
        /// </summary>     
        MediaActivity = 3,

        /// <summary>
        /// Соавторские проекты Co-author
        /// </summary>     
        CoAuthor = 4,

        /// <summary>
        /// Созданные чужие проекты Creator
        /// </summary>     
        CreatorActivity = 5,

        /// <summary>
        /// Лайки (количество выставленных)
        /// </summary>     
        LikingActivity = 6,

        /// <summary>
        /// Лайки (количество полученных на связанные проекты)
        /// </summary>     
        Liked = 7,

        /// <summary>
        /// Работа модератора
        /// </summary>     
        ModerationActivity = 8,

        /// <summary>
        /// Связанный с пользователем проект был выбран модератором
        /// </summary>     
        Moderated = 9
    }
}
