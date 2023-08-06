using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;
namespace crudApp.Models
{
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? Name { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public double Salary { get; set; }
        public string? Department { get; set; }
        [RegularExpression(@"^[MF]+$")]
        public string? Type { get; set; }
    }
}
