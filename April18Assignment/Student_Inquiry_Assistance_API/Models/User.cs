using System.ComponentModel.DataAnnotations;

namespace Student_Inquiry_Assistance_API.Models
{
    public class User
    {
        public string Email { get; set; }
        public long UserId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string MobileNumber { get; set; }
        public string UserRole { get; set; }
        public Student? Student { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
