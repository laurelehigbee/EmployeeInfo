using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeInfo.Models
{
    public class Program
    {
        [Key]
        [Required]
        public int ProgramID { get; set; }
        public string ProgramDesc { get; set; }
    }
}
