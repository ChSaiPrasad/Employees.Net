using System.ComponentModel.DataAnnotations;

namespace FullStackProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50,ErrorMessage ="Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format")]
        [Display(Name ="Office Mail")]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }

        //public Dept? Department { get; set; } in this ? means nullable(the value is optional to pass
    }
}
