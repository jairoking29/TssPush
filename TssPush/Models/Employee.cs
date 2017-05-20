using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TssPush.Models
{
    class Employee
    {
        public const string EMPLOYEE_ROW_TYPE = "D";
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string EmployeeId { get; set; }

        public decimal Salary { get; set; }

        public DateTime StartDate { get; set; }
    }
}
