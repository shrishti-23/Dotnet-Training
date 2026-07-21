using System.ComponentModel.DataAnnotations;

namespace _21jul.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student name is Mandatory")]
        [StringLength(20,MinimumLength=3, ErrorMessage ="Student name must be atleast of length three")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Student age is Mandatory")]
        [Range(18,25, ErrorMessage ="Student Age must be betwwen 18 and 25")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Student email is Mandatory")]
        [EmailAddress(ErrorMessage = "Email is incorrrect.Enter a valid email id")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Student enrolled course name is Mandatory")]
        
        public string Course { get; set; }
    }
}
