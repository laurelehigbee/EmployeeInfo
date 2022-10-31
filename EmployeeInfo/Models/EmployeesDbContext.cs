using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace EmployeeInfo.Models
{
    public class EmployeesDbContext
    {
        public string ConnectionString { get; set; }

        public EmployeesDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Employee", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Employee()
                        {
                            BYUID = reader["BYUID"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            BYUName = reader["BYUName"].ToString(),
                            PhoneNumber=reader["PhoneNumber"].ToString(),
                            EmailAddress=reader["EmailAddress"].ToString(),
                            Gender = (bool)reader["Gender"],
                            ProgramID=(int)reader["ProgramID"],
                            CitizenshipID = (int)reader["CitizenshipID"],
                            // DateStartGradTuition= (DateTime)reader["DateStartGradTuition"],
                            Notes=reader["Notes"].ToString()
                        }); ;
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
