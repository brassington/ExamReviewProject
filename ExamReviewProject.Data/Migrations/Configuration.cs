namespace ExamReviewProject.Data.Migrations
{
    using ExamReviewProject.DataModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExamReviewProject.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExamReviewProject.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Companies.AddOrUpdate(
              p => p.Id,
              new Company { Id = 1, CompanyName = "Google" },
              new Company { Id = 2, CompanyName = "Facebook" },
              new Company { Id = 3, CompanyName = "Famous" }
            );

            context.Jobs.AddOrUpdate(
             p => p.Id,
            new Job { Id = 1, JobTitle = "Lead Engineer", Salary = 80000.00, CompanyId = 3},
            new Job { Id = 2, JobTitle = "Frontend Engineer", Salary = 180000.00, CompanyId = 1 },
            new Job { Id = 3, JobTitle = "Backend Engineer", Salary = 130000.00, CompanyId = 2 }
            );

        }
    }
}
