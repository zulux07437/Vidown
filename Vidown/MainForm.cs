using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidown
{
    public partial class MainForm : Form
    {
#if DEBUG
        private static bool IsDebug = true;
#else // Release
        private static bool IsDebug = false;
#endif
        private static string videoID = "YGrdLX8eKQY";
        private static string path = @$"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}";

        public MainForm()
        {
            // Constructor
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsDebug) return; // If it's debug, Quit

            DialogResult result = MessageBox.Show("Are you sure you want to close?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void MenuStrip_Help_AboutOfThis_Click(object sender, EventArgs e)
        {
            Forms.AboutOfThis at = new Forms.AboutOfThis();
            at.ShowDialog();
        }
        private void MenuStrip_File_Settings_Click(object sender, EventArgs e)
        {
            Forms.Settings s = new Forms.Settings();
            s.ShowDialog();
        }

        private async void Button_Start_Click(object sender, EventArgs e)
        {
            Progress<double> progress = new Progress<double>(Progress_OnProgressChanged);
            if (await Functions.DownloadWebm(TextBox_VideoID.Text, path, progress))
                ChangeStatusText("Stating...");
            else
                ChangeStatusText("Error");
        }

        private void Progress_OnProgressChanged(double count)
        {
            StatusStrip_ProgressBar.Value = (int)(count * 100); // Multiply by 100 because the highest is 1
            ChangeStatusText("Downloading: " + ((int)(count * 100)).ToString() + "%");
        }
        private void ChangeStatusText(string text)
        {
            StatusStrip_Status.Text = text;
        }
    }
}
