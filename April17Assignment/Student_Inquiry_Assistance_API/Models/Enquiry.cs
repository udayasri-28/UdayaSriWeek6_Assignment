using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Inquiry_Assistance_API.Models
{
    public class Enquiry
    {
        [Key]
        public int EnquiryID { get; set; }
        public DateTime EnquiryDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EnquiryType { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
