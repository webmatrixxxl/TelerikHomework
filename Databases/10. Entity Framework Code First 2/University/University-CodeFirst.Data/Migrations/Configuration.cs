namespace University_CodeFirst.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using University_CodeFirst.Models;

    public sealed class Configuration : DbMigrationsConfiguration<University_CodeFirst.Data.University_CodeFirstContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(University_CodeFirst.Data.University_CodeFirstContext context)
        {
            context.Course.AddOrUpdate(
            c => c.Name,
                    new Course { Name = "Databases", Description = "Telerik Academy Databases course", Materials="Kraka" },
                    new Course { Name = "C#", Description = "Telerik Academy C# course", Materials="Knigi" }
                );

            context.Student.AddOrUpdate(
            s => s.Name,
                    new Student { Name = "Kiro", Number = 12 },
                    new Student { Name = "Mitio", Number = 21 },
                    new Student { Name = "Pesho", Number = 22 }
                );

            context.Student
                .Where(x => x.Number == 12)
                .First()
                .Courses.Add(context.Course.Where(c => c.Name == "C#").First());

            context.Student
                .Where(x => x.Number == 21)
                .First()
                .Courses.Add(context.Course.Where(c => c.Name == "Databases").First());

            context.Student
                .Where(x => x.Number == 22)
                .First()
                .Courses.Add(context.Course.Where(c => c.Name == "C#").First());


            context.SaveChanges();
        }
    }
}
