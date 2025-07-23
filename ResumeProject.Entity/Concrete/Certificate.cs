using Core.Entities;

namespace ResumeProject.Entity.Concrete
{
    public sealed class Certificate : BaseEntity
    {
        public string Title { get; set; }
        public DateTime DateAt { get; set; }
        public string Degree { get; set; }
        public string Organization { get; set; }
        public string Description { get; set; }
    }


}
