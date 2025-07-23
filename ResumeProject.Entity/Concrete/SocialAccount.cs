using Core.Entities;

namespace ResumeProject.Entity.Concrete
{
    public sealed class SocialAccount : BaseEntity
    {
        public string Name { get; set; }
        public string WebUrl { get; set; }
        public string UserName { get; set; }
        public string Icon { get; set; }
    }


}
