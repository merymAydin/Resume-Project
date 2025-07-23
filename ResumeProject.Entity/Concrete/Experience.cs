using Core.Entities;

namespace ResumeProject.Entity.Concrete
{
    public sealed class Experience : BaseEntity
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }


}
