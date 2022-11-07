using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace EmployeeInfo.Models
{
    public class StudentJobDbContext
    {
        public string ConnectionString { get; set; }

        public StudentJobDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<StudentJob> GetAllStudentJobs()
        {
            List<StudentJob> list = new List<StudentJob>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from StudentJob", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StudentJob()
                        {
                            JobID = (int)reader["JobID"],
                            EmployeeID = reader["EmployeeID"].ToString(),
                            PositionID = (int)reader["PositionID"],
                            SupervisorID = reader["SupervisorID"].ToString(),
                            EmpRecordNum = (int)reader["EmpRecordNum"],
                            ExpectedHours = (float)reader["ExpectedHours"],
                            ClassCode = reader["ClassCode"].ToString(),
                            DateHired = (DateTime)reader["DateHired"],
                            DateNameChange = (DateTime)reader["DateNameChange"],
                            DateTerminated = (DateTime) reader["DateTerminated"],
                            DateSurveySent = (DateTime)reader["DateSurveySent"],
                            DateFormSubmitted = (DateTime)reader["DateFormSubmitted"],
                            DateAuthorized = (DateTime)reader["DateAuthorized"],
                            Notes = reader["Notes"].ToString()
                        });
                    }
                }
            }
            return list;
        }
        public DbSet<Citizenship> Citizenships { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmpPosition> EmpPositions { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<SemesterJob> SemesterJobs { get; set; }
        public DbSet<StudentJob> StudentJobs { get; set; }
        public DbSet<WageChange> WageChanges { get; set; }
    }
}

