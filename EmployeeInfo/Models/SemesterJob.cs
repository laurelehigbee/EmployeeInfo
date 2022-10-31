using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeInfo.Models
{
    public class SemesterJob
    {
        [Key]
        [Required]
        [ForeignKey("SemesterID")]
        public Semester Semester { get; set; }
        public int SemesterID { get; set; }

        [Key]
        [Required]
        [ForeignKey("JobID")]
        public StudentJob StudentJob { get; set; }
        public int JobID { get; set; }

        [Key]
        [Required]
        public int JobYear { get; set; }
    }
}
