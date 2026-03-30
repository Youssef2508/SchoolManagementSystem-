using System.ComponentModel.DataAnnotations;

namespace Project_1.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Range(5, 18)]
        public int Age { get; set; }

        [Required]
        [RegularExpression(@"^\d+(st|nd|rd|th)$",
        ErrorMessage = "Grade must be like 1st, 2nd, 3rd, 4th")]
        public string GradeLevel { get; set; }
    }
}