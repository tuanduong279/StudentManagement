using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(250)"), Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please choose gender")]
        public bool Gender { get; set; }
        [Column(TypeName = "date"), Required(ErrorMessage = "The value '' is invalid"), DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "time(7)"), Required(ErrorMessage = "The value '' is invalid"), DisplayName("Batch Time")]
        public TimeSpan BatchTime { get; set; }
        [Column(TypeName = "varchar(20)"), Required(ErrorMessage = "Please enter phone number"), DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "varchar(100)"), Required(ErrorMessage = "Please enter email address"), DisplayName("Email Address")]
        public string EmailAddress { get; set; }
        [Column(TypeName = "nvarchar(250)"), Required(ErrorMessage = "Please enter website URL"), DisplayName("Website URL")]
        public string WebsiteURL { get; set; }
        [Column(TypeName = "nvarchar(250)"), Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match. Type again!"), Required(ErrorMessage = "Please enter confirm password"), DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}