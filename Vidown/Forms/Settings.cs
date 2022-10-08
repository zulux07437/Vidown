using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vidown.Properties;

namespace Vidown.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            TextBox_OutputPath.Text = Properties.Settings.Default.OutputPath;
        }
        private void Button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                string outputPath = TextBox_OutputPath.Text;
                if (Directory.Exists(outputPath))
                    Properties.Settings.Default.OutputPath = outputPath;
                else
                    throw new Exception("Folder not found: " + outputPath);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_OutputPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
                fbd.SelectedPath = @"C:\";
                fbd.ShowNewFolderButton = true;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    TextBox_OutputPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
