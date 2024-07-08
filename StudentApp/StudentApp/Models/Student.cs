using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace StudentInfoWeb.Models
{
    public class Student
    {
        [Required]
        public int Student_Id { get; set; }
        [Required]
        public string Student_Name { get; set; }
        [Required]
        [EmailAddress]
        public string Student_Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid mobile number")]
        public string Mobile_number { get; set; }

        [Required]
        public string Student_Address { get; set; }


        public DateTime Admission_Date { get; set; }

        [Required]
        public float Fees { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
