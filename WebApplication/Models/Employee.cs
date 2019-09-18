using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Employee Code")]
        public string EmployeeCode { get; set; }
        [Column]
        [Required]
        public Positions? Position { get; set; }

    }
}
