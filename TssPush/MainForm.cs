using System;
using System.IO;
using System.Windows.Forms;

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
            Exporter.ExportTSSFile(path);
            MessageBox.Show("Documento generado satisfactoriamente en \"" + 
                path + "/TSS.dat\"");
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
