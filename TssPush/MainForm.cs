using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TssPush.Models;
using TssPush.Utils;

namespace TssPush
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            var path = FolderPathInput.Text;
            var employees = DataMock.GetMockEmployees();
            using (var writer = new StreamWriter(path + "/hue.dat", false))
            {
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
                }
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();

            var path = folderBrowser.SelectedPath;
            FolderPathInput.Text = path;
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            GenerateBtn.Enabled = true;
        }
    }
}
