namespace TssPush.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TssPush.Models.TssDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TssPush.Models.TssDb context)
        {
            //  This method will be called after migrating to the latest version.

            context.Employees.AddOrUpdate( e => e.EmployeeId,
                new Employee() { Name = "Jairo", LastName = "Mancebo", EmployeeId = "402-2567436-1", Salary = 13760.99M, StartDate = new DateTime(2016, 11, 29) },
                new Employee() { Name = "Janna", LastName = "Aquino", EmployeeId = "001-1936032-9", Salary = 24579.45M, StartDate = new DateTime(2015, 04, 26) },
                new Employee() { Name = "Rey", LastName = "Cabral", EmployeeId = "001-0000000-0", Salary = 36800.27M, StartDate = new DateTime(2013, 05, 18) },
                new Employee() { Name = "Eduardo", LastName = "Mancebo", EmployeeId = "001-1936032-8", Salary = 40000.00M, StartDate = new DateTime(2010, 08, 10) }
            );

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
