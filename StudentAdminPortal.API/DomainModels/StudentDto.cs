using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.DomainModels
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? Lastname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Email { get; set; }
        public long? Mobile { get; set; }
        public string? profileImageUrl { get; set; }
        public Guid? GenderId { get; set; }

        //Navigation Properties
        public GenderDto? Gender { get; set; }
        public AddressDto? Address { get; set; }
    }
}
