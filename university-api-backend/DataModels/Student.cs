using System.ComponentModel.DataAnnotations;

namespace university_api_backend.DataModels
{
    public class Student: BaseEntity
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Dob { get; set; } //fecha de nacimiento
        
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
