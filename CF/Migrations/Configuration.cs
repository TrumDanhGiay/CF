namespace CF.Migrations
{
    using CF.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CF.Models.StudentCOntext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CF.Models.StudentCOntext";
        }

        protected override void Seed(CF.Models.StudentCOntext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Student.ToList().ForEach(a => a.Status2 = 1);
            context.SaveChanges();
        }
    } 
}
