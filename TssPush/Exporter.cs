using System;
using System.IO;
using System.Linq;
using TssPush.Models;
using TssPush.Utils;

namespace TssPush
{
    class Exporter
    {
        private const string ENTITY_NAME = "Ferretería Americana";
        private const string RNC = "1-01-00991-8";
        private const string ROW_TYPE_HEADER = "E";
        private const string ROW_TYPE_FOOTER = "S";

        private static TssDb db = new TssDb();

        public static void ExportTSSFile(string path)
        {
            var employees = db.Employees.ToList();
            var numberOfRows = 0;
            using (var writer = new StreamWriter(path + "/TSS.dat", false))
            {
                var firstLine = GetHeaderLine();
                writer.WriteLine(firstLine);
                foreach (var employee in employees)
                {
                    var line = "";
                    line += Employee.EMPLOYEE_ROW_TYPE + ' ';
                    line += Formatter.FormatString(employee.EmployeeId, 13);
                    line += Formatter.FormatString(employee.Name, 30);
                    line += Formatter.FormatString(employee.LastName, 30);
                    line += Formatter.FormatNumber(employee.Salary, 12);
                    line += Formatter.FormatDate(employee.StartDate);
                    writer.WriteLine(line);
                    numberOfRows++;
                }
                writer.WriteLine(GetFooterLine(numberOfRows));
            }
        }

        private static string GetHeaderLine()
        {
            var firstLine = Formatter.FormatString(ROW_TYPE_HEADER, 3) + Formatter.FormatString(ENTITY_NAME, 10)
                + Formatter.FormatString(RNC, 12) + Formatter.FormatDate(DateTime.Now);

            return firstLine;
        }

        private static string GetFooterLine(int numRows)
        {
            var lastLine = ROW_TYPE_FOOTER + Formatter.FormatNumber(numRows, 9);
            return lastLine;
        }
    }
}
