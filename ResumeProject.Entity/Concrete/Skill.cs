using Core.Entities;

namespace ResumeProject.Entity.Concrete
{
    public sealed class Skill : BaseEntity
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public bool IsProgramLanguageAndTool { get; set; }
    }


}
