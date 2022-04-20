using Burgundy.Project.Models.Geograffee;
using Burgundy.Shared.Models.Types.Enums;
using Reinforced.Typings.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgundy.Project.Models.Types
{
    /// <summary>
    /// Модель для выдачи проектов по фильтру
    /// </summary>
    [TsClass]
    public class CombineProjectFilter
    {
        public string CompetitionId { get; set; }
        public int Year { get; set; }
        public string Course { get; set; }
        public List<string> CuratorIdList { get; set; }
        public string Search { get; set; }
        public bool IsStudent { get; set; }
        public List<string> TagIds { get; set; }
        public string CategoryId { get; set; }
        public ProjectFilter Filter { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
    }
}
