using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CF.Models
{
    public class StudentCOntext : DbContext
    {
        public StudentCOntext() : base("DefaultConnection")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
        }
        public DbSet<Student> Student { get; set; }

        public override int SaveChanges()
        {
            var modifiedEntities = ChangeTracker.Entries()
        .Where(p => p.State == EntityState.Modified).ToList();
            var now = DateTime.UtcNow;
            return base.SaveChanges();
        }
    }
}