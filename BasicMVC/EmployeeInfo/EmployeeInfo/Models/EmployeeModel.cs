using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeInfo.Models
{
    [Table("EmployeeGit")]
    public class EmployeeGit
    {
        [Key, DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public DateTime DateofJoining { get; set; }
    }

    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("EmployeeContext") { }
        public DbSet<EmployeeGit> employeeModel { get; set; }
    }
}