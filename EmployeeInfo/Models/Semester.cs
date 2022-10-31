using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeInfo.Models
{
    public class Semester
    {
        [Key]
        [Required]
        public int SemesterID { get; set; }

        public string SemesterDesc { get; set; }
    }
}
