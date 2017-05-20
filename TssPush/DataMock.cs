using System;
using System.Collections.Generic;
using TssPush.Models;

namespace TssPush
{
    class DataMock
    {
        public static List<Employee> GetMockEmployees()
        {
            return new List<Employee>()
            {
                new Employee() { Name = "Jairo", LastName = "Mancebo", EmployeeId = "402-2567436-1", Salary = 13760.99M, StartDate = new DateTime(2016, 11, 29) },
                new Employee() { Name = "Janna", LastName = "Aquino", EmployeeId = "001-1936032-9", Salary = 24579.45M, StartDate = new DateTime(2015, 04, 26) },
                new Employee() { Name = "Rey", LastName = "Cabral", EmployeeId = "001-0000000-0", Salary = 36800.27M, StartDate = new DateTime(2013, 05, 18) },
                new Employee() { Name = "Eduardo", LastName = "Mancebo", EmployeeId = "001-1936032-8", Salary = 40000.00M, StartDate = new DateTime(2010, 08, 10) }
            };
        }
    }
}
