using Reinforced.Typings.Fluent;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgundy.Project.Models.typings
{
    /// <summary>
    /// Класс конфигирует парамертры конвертации в ts
    /// Подробнее https://github.com/reinforced/Reinforced.Typings/wiki/Fluent-configuration#class
    /// </summary>
    public class TypingsConfiguration
    {
        public static void ConfigureTypings(ConfigurationBuilder builder)
        {
            builder.Global(x => x.CamelCaseForProperties());
        }
    }
}
