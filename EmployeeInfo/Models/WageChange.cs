using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeInfo.Models
{
    public class WageChange
    {
        [Key]
        [Required]
        [ForeignKey("JobID")]
        public StudentJob StudentJob { get; set; }
        public int JobID { get; set; }

        [Key]
        [Required]
        public DateTime DateWageChanged { get; set; }

        public DateTime DateWageInput { get; set; }

        public float NewWage { get; set; }
    }
}
