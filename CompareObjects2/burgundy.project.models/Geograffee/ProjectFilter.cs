using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{

    /// <summary>
    /// Необходим для определения порядка выдачи проектов в географии
    /// </summary>
    public enum ProjectFilter
    {
        /// <summary>
        /// По дате публикации
        /// </summary>
        Fresh = 1,

        /// <summary>
        /// По лайкам
        /// </summary>
        Popular = 2,

        /// <summary>
        /// По сезону
        /// </summary>     
        Season = 3,

        /// <summary>
        /// По номинации
        /// </summary>
        Nomination = 4,

        /// <summary>
        /// По дате изменения
        /// </summary>
        Edited = 5,
        /// <summary>
        /// По фамилии
        /// </summary>
        SurName = 6


    }
}
