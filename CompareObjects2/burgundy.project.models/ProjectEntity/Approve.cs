using System;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.ProjectEntity
{
    /// <summary>
    /// Одобрение
    /// </summary>
    [TsClass]
    public class Approve
    {
        /// <summary>
        /// Идентификатор одобрения
        /// </summary>
        public string ApproveId { get; set; }
        /// <summary>
        /// Идентифатор
        /// </summary>
        public string AccountId { get; set; }
        /// <summary>
        /// Флаг дал он подтверждение или нет
        /// </summary>
        public bool IsApproved { get; set; } 
        /// <summary>
        /// Дата 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Дополнительные данные
        /// </summary>
        public string Data { get; set; }
        
        /// <summary>
        /// Сервис КУДА одобрен доступ
        /// </summary>
        public  string Service { get; set; } 
        /// <summary>
        /// Контекст сервиса куда одобрен доступ
        /// </summary>
        public string ContextService { get; set; }
        
    }
}