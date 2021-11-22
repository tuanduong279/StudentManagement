using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement.Models;

namespace StudentManagement.Models
{
    public class StudentsContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentsContext(DbContextOptions<StudentsContext> options)
            : base(options)
        { }
    }
}