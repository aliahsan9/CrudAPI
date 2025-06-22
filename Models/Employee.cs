using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        public int Age { get; set; }

        [Required]
        public required string Designation { get; set; }

        public int Salary { get; set; }
    }
}
     