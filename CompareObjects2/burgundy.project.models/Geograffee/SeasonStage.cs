using Burgundy.Project.Models.Types;
using Burgundy.Shared.Models.Types;
using Reinforced.Typings.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgundy.Project.Models.Geograffee
{
    [TsClass]
    public class SeasonStage
    {
        /// <summary>
        /// Enum текущего этапа
        /// </summary>
        public SeasonStageEnum SeasonStageEnum { get; set; }

        /// <summary>
        /// Имя этапа
        /// </summary>
        public List<NameObject> StageName { get; set; }


        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public CompetitionStatus CompetitionStatus { get; set; }
        
        public bool IsActive { get; set; }
        public bool UserCanApplyProject { get; set; }
        public bool UserCanEditProject { get; set; }
        public bool UserCanVote { get; set; }
        public bool JuryCanVote { get; set; }

        /// <summary>
        /// Текстовое описание дат
        /// </summary>
        public List<NameObject> DatetimeString { get; set; }

        public SeasonStage()
        {
            SeasonStageEnum = SeasonStageEnum.Created;
            StageName = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            DatetimeString = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            StartDateTime = DateTime.MinValue;
            EndDateTime = DateTime.MinValue;
            CompetitionStatus = CompetitionStatus.Draft;
            IsActive = false;
            UserCanApplyProject = false;
            UserCanEditProject = false;
            UserCanVote = false;
            JuryCanVote = false;
        }

    }
}
