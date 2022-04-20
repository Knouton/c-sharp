namespace Burgundy.Project.Models.Opa
{
    /// <summary>
    /// Кол-во отобранных и отказанных проектов по контексту
    /// Если перенес в контекст - accepted+
    /// Если убрал с контекста - declined+
    /// </summary>
    public class ModeratedProject
    {
        /// <summary>
        /// Контекст куда отправили
        /// </summary>
        public string Context { get; set; }
        public int Accepted { get; set; }
        public int Declined { get; set; }
    }
}