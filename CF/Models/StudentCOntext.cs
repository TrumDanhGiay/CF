using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CF.Models
{
    public class StudentCOntext  : DbContext
    {
        public StudentCOntext() : base("DefaultConnection")
        {
            
        }
        public DbSet<Student> Student { get; set; }
    }
}