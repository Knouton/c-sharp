using Reinforced.Typings.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgundy.Project.Models.Types
{
    /// <summary>
    /// Состояния сезона конкурса
    /// </summary>
    [TsEnum]
    public enum SeasonStageEnum
    {
        /// <summary>
        /// Сезон только объявлен, никаких работ еще не проводится
        /// </summary>
        Created = 0,
        /// <summary>
        /// Прием проектов
        /// </summary>
        Ongoing = 1,

        /// <summary>
        /// Оценка проектов
        /// </summary>
        Scoring = 2,

        /// <summary>
        /// Объявление финалистов
        /// </summary>
        Pre_results = 3,

        /// <summary>
        /// Объявление победителей
        /// </summary>
        Results = 4,
    }
}
