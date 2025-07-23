using Core.Entities;

namespace ResumeProject.Entity.Concrete
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public byte Level { get; set; }

    }


}
