using System.Collections.Generic;

namespace Burgundy.Geography.Models.TransferModels.AutoGenerate
{
   // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Author
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string shortname { get; set; }
        public string fullname { get; set; }
        public string imageUrl { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
        public object groups { get; set; }
        public List<object> roles { get; set; }
        public object rights { get; set; }
        public object statistic { get; set; }
        public List<object> managers { get; set; }
        public List<object> managedUsers { get; set; }
    }

    public class Lecture
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string shortname { get; set; }
        public string fullname { get; set; }
        public string imageUrl { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
        public object groups { get; set; }
        public List<object> roles { get; set; }
        public object rights { get; set; }
        public object statistic { get; set; }
        public List<object> managers { get; set; }
        public List<object> managedUsers { get; set; }
    }

    // public class CoverWork
    // {
    //     public int id { get; set; }
    //     public string title { get; set; }
    //     public string description { get; set; }
    //     public string url { get; set; }
    //     public bool isCover { get; set; }
    //     public List<object> systemTags { get; set; }
    //     public bool isHidden { get; set; }
    //     public int order { get; set; }
    //     public string imageUrl { get; set; }
    //     public string pageUrl { get; set; }
    //     public int userProjectId { get; set; }
    //     public object userProject { get; set; }
    // }

    public class Work
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public bool isCover { get; set; }
        public List<object> systemTags { get; set; }
        public bool isHidden { get; set; }
        public int order { get; set; }
        public string imageUrl { get; set; }
        public string pageUrl { get; set; }
        public int userProjectId { get; set; }
        public object userProject { get; set; }
    }

    public class UserProjectTag
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public int academicYear { get; set; }
        public int course { get; set; }
        public int learningType { get; set; }
        public string learningTypeName { get; set; }
        public int learningForm { get; set; }
        public string learningFormName { get; set; }
        public int curatorId { get; set; }
        public object curator { get; set; }
        public int administratorId { get; set; }
        public object administrator { get; set; }
        public object disciplineId { get; set; }
        public object discipline { get; set; }
        public int directionId { get; set; }
        public object direction { get; set; }
        public int programId { get; set; }
        public int learningProfileId { get; set; }
        public object learningProfile { get; set; }
        public object learningProfileSpecId { get; set; }
        public object learningProfileSpec { get; set; }
    }

    public class ModuleCourse
    {
        public int id { get; set; }
        public int groupId { get; set; }
        public Group group { get; set; }
        public int moduleId { get; set; }
        public object module { get; set; }
        public int disciplineId { get; set; }
        public object discipline { get; set; }
        public int hoursCount { get; set; }
        public int controlForm { get; set; }
        public bool isShowMarks { get; set; }
        public bool isCalcMarksByAttendance { get; set; }
        public object earlyViewStartMarking { get; set; }
    }

    public class UserProject
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public long createDate { get; set; }
        public bool isModerated { get; set; }
        public int moduleCourseId { get; set; }
        public int learningType { get; set; }
        public int mark { get; set; }
        public string pageUrl { get; set; }
        public List<object> tags { get; set; }
        public List<Author> authors { get; set; }
        public Lecture lecture { get; set; }
        public Work coverWork { get; set; }
        public List<Work> works { get; set; }
        public List<UserProjectTag> userProjectTags { get; set; }
        public ModuleCourse moduleCourse { get; set; }
    }


}