using System.ComponentModel.DataAnnotations;

namespace HomePage.Models
{
    public class StudentAccess
    {
        public List<Student> Students { get; set; } = new List<Student>();
        [Required(ErrorMessage = "Please enter your access level")]
        [Range(1, 10, ErrorMessage ="Access level can be only between 1 and 10")]
        public int AccessLevel { get; set; }

    }
}
