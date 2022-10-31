using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeInfo.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public string BYUID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BYUName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public bool Gender { get; set; }

        [ForeignKey("ProgramID")]
        public Program Program { get; set; }
        public int ProgramID { get; set; }

        [ForeignKey("CitizenshipID")]
        public Citizenship Citizenship { get; set; }
        public int CitizenshipID { get; set; }

        public DateTime DateStartGradTuition { get; set; }

        public string Notes { get; set; }

        //how do you do foreign keys??

    }
}
