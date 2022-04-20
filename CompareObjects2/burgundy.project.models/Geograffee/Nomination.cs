using System;
using System.Collections.Generic;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson.Serialization.Attributes;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    /// <summary>
    /// Отвечает за номинации в конкурсе(Competition)
    /// </summary>
    [BsonIgnoreExtraElements]
    [TsClass]
    public class Nomination : ICloneable
    {
        public string NominationID { get; set; }


        /// <summary>
        /// Категория по которой происходит конкурс
        /// Будет удалено, нужно использовать CategoriesID
        /// </summary>
        [Obsolete]
        public string CategoryID { get; set; }

        /// <summary>
        /// Категории по которым происходит конкурс
        /// </summary>
        public List<string> CategoriesId { get; set; }

        public List<NameObject> Name { get; set; }

        /// <summary>
        /// Здесь пишем описание. К примеру:
        /// Ждём проекты по анимационному этюду в жанре анимадока
        /// Показать проект акцидентного шрифта и процесс его создания
        /// </summary>
        public List<NameObject> Description { get; set; }

        /// <summary>
        /// Условия участия
        /// </summary>
        public List<NameObject> Terms { get; set; }

        /// <summary>
        /// Требования к оформлению
        /// </summary>
        public List<NameObject> Formatting { get; set; }

        /// <summary>
        /// Все участники
        /// </summary>
        public List<string> ParticipantsID { get; set; }

        /// <summary>
        /// Отобранный шортлист
        /// </summary>
        public List<string> FinalistsID { get; set; }

        /// <summary>
        /// Победители по данной номинации
        /// </summary>
        public List<string> WinnersID { get; set; }
        
        /// <summary>
        /// Критерии оценки жюри по номинации
        /// </summary>
        public List<string> VoteCriteriasID { get; set; }
        
        [BsonIgnore]
        public List<VoteCriteria> VoteCriterias { get; set; }
        
        public Nomination()
        {
            Name = new List<NameObject>()
                {new NameObject {Lang = "ru", Name = ""}, new NameObject {Lang = "en", Name = ""}};
            CategoriesId = new List<string>();
            Description = new List<NameObject>()
                {new NameObject {Lang = "ru", Name = ""}, new NameObject {Lang = "en", Name = ""}};
            Terms = new List<NameObject>()
                {new NameObject {Lang = "ru", Name = ""}, new NameObject {Lang = "en", Name = ""}};
            Formatting = new List<NameObject>()
                {new NameObject {Lang = "ru", Name = ""}, new NameObject {Lang = "en", Name = ""}};
            ParticipantsID = new List<string>();
            FinalistsID = new List<string>();
            WinnersID = new List<string>();
            VoteCriteriasID = new List<string>();
            VoteCriterias = new List<VoteCriteria>();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}