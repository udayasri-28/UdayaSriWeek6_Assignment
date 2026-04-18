using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Inquiry_Assistance_API.Models
{
    public class Admission
    {
        [Key]
        public int AdmissionID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Status { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public Student? Student { get; set; }
        public Course? Course { get; set; }
        public ICollection<Payment>? Payments { get; set; }
    }
}
