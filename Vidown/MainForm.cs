using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vidown.CliProcessWrap;

namespace Vidown
{
    public partial class MainForm : Form
    {
#if DEBUG
        private readonly static bool IsDebug = true;
#else // Release
        private readonly static bool IsDebug = false;
#endif
        private Functions f = new();
        private readonly static string path = @$"{System.IO.Directory.GetCurrentDirectory()}\bin";
        private static string artistName = null;
        private static string titleName = null;
        private static Functions.Extensions extension;

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
            Forms.AboutOfThis at = new();
            at.ShowDialog();
        }
        private void MenuStrip_File_Settings_Click(object sender, EventArgs e)
        {
            Forms.Settings s = new();
            s.ShowDialog();
        }

        private async void Button_Get_Click(object sender, EventArgs e)
        {
            Button_Get.Enabled = false;
            ChangeStatusText("Getting...");

            if (await f.GetVideo(TextBox_VideoID.Text) == false) // If it fails
            {
                ChangeStatusText("Error");
                Button_Get.Enabled = true;
                return;
            }
            foreach (var add in f.Qualities)
                ComboBox_Quality.Items.Add(add);

            ChangeStatusText("Already got");
            Button_Get.Enabled = true;
            Button_Start.Enabled = true;
        }
        private async void Button_Start_Click(object sender, EventArgs e)
        {
            try
            {
                Button_Start.Enabled = false;
                ChangeStatusText("Starting...");
                string inputName = "input.webm";

                Progress<double> progress = new(Progress_OnProgressChanged);
                if (extension == Functions.Extensions.MP3 || extension == Functions.Extensions.WebmAudio || true)
                {
                    inputName = await f.DownloadAudio(path, progress);
                }
                else if (extension == Functions.Extensions.MP4 || extension == Functions.Extensions.WebmVideo)
                {
                    inputName = await f.DownloadVideo(path, ComboBox_Quality.Text, progress);
                }
                if (inputName == null) // If it fails
                {
                    throw new Exception("Error");
                }

                ffmpeg.ExtensionConversion($@"{path}\{inputName}", $@"{path}\{artistName} - {titleName}.mp3");
                System.IO.File.Delete($@"{path}\{inputName}");

                ChangeStatusText("Complete");
                InitializeInstances();
            }
            catch (Exception ex)
            {
                ChangeStatusText(ex.Message);
                Button_Start.Enabled = true;
            }
        }
        private void TextBox_Artist_TextChanged(object sender, EventArgs e)
        {
            artistName = TextBox_Artist.Text;
            UpdateFileNameLabel();
        }
        private void TextBox_Title_TextChanged(object sender, EventArgs e)
        {
            titleName = TextBox_Title.Text;
            UpdateFileNameLabel();
        }
        private void UpdateFileNameLabel()
        {
            Label_FileName.Text = $"{artistName} - {titleName}";
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
        private void InitializeInstances()
        {
            f = new();
            ComboBox_Quality.Items.Clear();
        }
    }
}
