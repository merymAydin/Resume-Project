using Core.Entities;

namespace ResumeProject.Entity.Concrete
{
    public sealed class PersonalInfo : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public bool MaritalStatus { get; set; } = false;
        public Gender Gender { get; set; }
        public string DrivingLicence { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; } = string.Empty;
        public string Nationality { get; set; } = "Turkish";
    }


}
