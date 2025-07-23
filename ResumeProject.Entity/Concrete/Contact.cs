using Core.Entities;

namespace ResumeProject.Entity.Concrete
{
    public sealed class Contact : BaseEntity
    {
        public string Address { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }


}
