using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Burgundy.Project.Models.ProjectEntity
{
    /// <summary>
    /// Отвечает за место работы/учебы и даты
    /// </summary>
   public class StudyOrWorkPlace
    {
        public string TeamId { get; set; }
        public DateTime SinceDateTime { get; set; }

        public DateTime ToDateTime { get; set; }

        public bool IsPresent { get; set; } = false;

        [BsonIgnore] public Team Team { get; set; } = new Team();

    }
}
