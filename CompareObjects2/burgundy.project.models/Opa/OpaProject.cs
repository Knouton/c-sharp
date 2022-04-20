using System.Collections.Generic;
using Burgundy.Project.Models.ProjectEntity;

namespace Burgundy.Project.Models.Opa
{
    /// <summary>
    /// Проект для рейтинга ОПА
    /// </summary>
    public class OpaProject
    {
        /// <summary>
        /// Идентификатор проекта
        /// </summary>
        public string ProjectId { get; set; }
        /// <summary>
        /// Идентификатор проекта внешней системы
        /// </summary>
        public string ProjectIdExternalSystem { get; set; } = string.Empty;
        /// <summary>
        /// Сервис
        /// </summary>
        public string Service { get; set; }
        /// <summary>
        /// Идентификатор 
        /// </summary>
        public string CompetitionId { get; set; } = string.Empty;
        /// <summary>
        /// Идентификатор лонгрида
        /// </summary>
        public string LongreadId { get; set; } = string.Empty;
        /// <summary>
        /// Статус проекта
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Список идентификаторов авторов
        /// </summary>
        public List<string> AuthorIds { get; set; } = new List<string>();
        /// <summary>
        /// Список Кураторов
        /// </summary>
        public List<string> CuratorsIdList { get; set; } = new List<string>();
        /// <summary>
        /// Пользователь
        /// </summary>
        public List<OpaUser> Users { get; set; } = new List<OpaUser>();
        /// <summary>
        /// Кураторы
        /// </summary>
        public List<OpaUser> Curators { get; set; } = new List<OpaUser>();
        /// <summary>
        /// Флаг наличия подтверждений (могут быть и отрицательные) 
        /// </summary>
        public bool IsApproved { get; set; } 
        /// <summary>
        /// Список одобрений
        /// </summary>
        public List<Approve> Approvals { get; set; } = new List<Approve>();
      

    }
}