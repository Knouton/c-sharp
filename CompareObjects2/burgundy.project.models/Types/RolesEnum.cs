using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Types
{
    /// <summary>
    /// Определяет возможности и доступы ролей в экосистеме географии
    /// </summary>
    [TsEnum]
    public enum RolesEnum
    {
        /// <summary>
        /// Модератор deziiign.
        /// Имеет возможность отправки проектов на hse.dz.com
        /// </summary>
        hsedzmoder,
        
        /// <summary>
        /// Модератор deziiign.
        /// Имеет возможность отправить проекты на hselab.dz.com
        /// Это "проектные юниты"
        /// </summary>
        hselabdzmoder,
    
    }
}