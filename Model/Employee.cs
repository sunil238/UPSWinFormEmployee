using System.ComponentModel.DataAnnotations;

namespace EmployeeDetails.Model
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        [EmailAddress]
        public string? email { get; set; }
        [Required]
        public string? gender { get; set; }
        [Required]
        public string? status { get; set; }
    }
}
