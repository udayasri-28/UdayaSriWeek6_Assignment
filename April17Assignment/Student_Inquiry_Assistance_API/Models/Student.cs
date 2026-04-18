using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Inquiry_Assistance_API.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmailId { get; set; }

        [ForeignKey("User")]
        public long? UserId { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Enquiry> Enquiries { get; set; }
        public ICollection<Admission> Admissions { get; set; }
        public User User { get; set; }
    }
}
