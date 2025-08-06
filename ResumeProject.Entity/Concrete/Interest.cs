using Core.Entities;

namespace ResumeProject.Entity.Concrete
{
    public sealed class Interest : BaseEntity
    {
        public string Description { get; set; }
        public byte Order { get; set; }
    }
}
