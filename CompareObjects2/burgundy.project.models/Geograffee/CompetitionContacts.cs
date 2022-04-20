using System.Collections.Generic;
using Burgundy.Shared.Models.Types;
using MongoDB.Bson.Serialization.Attributes;
using Reinforced.Typings.Attributes;

namespace Burgundy.Project.Models.Geograffee
{
    [BsonIgnoreExtraElements]
    [TsClass]

    public class CompetitionContacts
    {
        public List<NameObject> Name { get; set; }
        public List<NameObject> Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public CompetitionContacts()
        {
            Name = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            Address = new List<NameObject>() { new NameObject { Lang = "ru", Name = "" }, new NameObject { Lang = "en", Name = "" } };
            Phone = string.Empty;
            Email = string.Empty;
        }
    }
}