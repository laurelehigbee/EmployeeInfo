using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeInfo.Models
{
    public class StudentJob
    {
        [Key]
        [Required]
        public int JobID { get; set; }

        [ForeignKey("BYUID")]
        public Employee Employee { get; set; }
        public string EmployeeID { get; set; }

        [ForeignKey("PositionID")]
        public EmpPosition EmpPosition { get; set; }
        public int PositionID { get; set; }

        [ForeignKey("BYUID")]
        public string SupervisorID { get; set; }

        public int EmpRecordNum { get; set; }

        public float ExpectedHours { get; set; }

        public string ClassCode { get; set; }

        public DateTime DateHired { get; set; }

        public DateTime DateNameChange { get; set; }

        public DateTime DateTerminated { get; set; }

        public DateTime DateSurveySent { get; set; }

        public DateTime DateFormSubmitted { get; set; }

        public DateTime DateAuthorized { get; set; }

        public string Notes { get; set; }
    }
}
