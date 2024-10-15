/*using System.ComponentModel.DataAnnotations;
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
*/


using System;
using System.ComponentModel.DataAnnotations;

namespace StudentInfoWeb.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        [StringLength(100)]
        public string StudentName { get; set; }

        [Required]
        [EmailAddress]
        public string StudentEmail { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid mobile number")]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string StudentAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Admission Date")]
        public string AdmissionDate { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Fees must be a positive number")]
        public float Fees { get; set; }

        [Required]
        [EnumDataType(typeof(StudentStatus))]
        public StudentStatus Status { get; set; }
    }

    
    

    public enum StudentStatus
    {
        Active,
        Inactive,
        Graduated,
        Expelled
    }
}
