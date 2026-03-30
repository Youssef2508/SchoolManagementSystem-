using System.ComponentModel.DataAnnotations;

namespace Project_1.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public string CourseName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]+$",
        ErrorMessage = "Room number must contain letters and numbers")]
        public string RoomNumber { get; set; }

        [Range(10, 30)]
        public int MaxCapacity { get; set; }
    }
}