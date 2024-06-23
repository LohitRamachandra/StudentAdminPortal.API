namespace StudentAdminPortal.API.DataModels
{
    public class Student
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
        public Gender? Gender { get; set; }
        public Address? Address { get; set; } 
    }
}
