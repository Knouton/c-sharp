namespace Burgundy.Geography.Models.TransferModels
{
    public class ProjectHseTask
    {
        /// <summary>
        /// Идентификатор проекта студента в партфолио
        /// </summary>
        public string ProjectId { get; set; }
        /// <summary>
        /// Идентификтаор пользователя
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// Идентификатор профайла
        /// </summary>
        public string ProfileId { get; set; }
    }
}