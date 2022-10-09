﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vidown.Wrapper;
using Vidown.Properties;

namespace Vidown
{
    public partial class MainForm : Form
    {
#if DEBUG
        private static readonly bool IsDebug = true;
#else // Release
        private static readonly bool IsDebug = false;
#endif
        private YTDownload ytdown = new();
        private static string artistName = null;
        private static string titleName = null;
        private static YTDownload.Extensions extension = YTDownload.Extensions.MP3;

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
            Forms.AboutOfThis form = new();
            form.ShowDialog();
        }
        private void MenuStrip_File_Settings_Click(object sender, EventArgs e)
        {
            Forms.Settings form = new();
            form.ShowDialog();
        }

        private async void Button_Get_Click(object sender, EventArgs e)
        {
            Button_Get.Enabled = false;
            ChangeStatusText("Getting...");

            if (await ytdown.GetVideo(TextBox_VideoID.Text) == true)
            {
                foreach (var add in ytdown.Qualities)
                    ComboBox_Quality.Items.Add(add);

                ChangeStatusText("Already got");
                Button_Get.Enabled = true;
                Button_Start.Enabled = true;
            }
            else // If it fails
            {
                ChangeStatusText("Error");
                Button_Get.Enabled = true;
                return;
            }
        }
        private async void Button_Start_Click(object sender, EventArgs e)
        {
            ChangeStatusText("Starting...");
            Button_Start.Enabled = false;
            try
            {
                string inputName = null;
                string path = Settings.Default.OutputPath;
                if (string.IsNullOrEmpty(path))
                {
                    path = $@"{System.IO.Directory.GetCurrentDirectory()}";
                }

                Progress<double> progress = new(Progress_OnProgressChanged);
                if (extension is YTDownload.Extensions.OGG or YTDownload.Extensions.MP3)
                {
                    inputName = await ytdown.DownloadAudio(path, progress);
                }
                else if (extension is YTDownload.Extensions.WebmVideo or YTDownload.Extensions.MP4)
                {
                    inputName = await ytdown.DownloadVideo(path, ComboBox_Quality.Text, progress);
                }

                if (inputName != null)
                {
                    ffmpeg.ExtensionConversion($@"{path}\{inputName}", $@"{path}\{artistName} - {titleName}", extension);
                    System.IO.File.Delete($@"{path}\{inputName}");
                }
                else // If it fails
                {
                    throw new Exception("Error");
                }

                InitializeInstances();
            }
            catch (Exception ex)
            {
                Button_Start.Enabled = true;
                ChangeStatusText(ex.Message);
            }
        }

        private void TextBox_Artist_TextChanged(object sender, EventArgs e)
        {
            artistName = TextBox_Artist.Text;
        }
        private void TextBox_Title_TextChanged(object sender, EventArgs e)
        {
            titleName = TextBox_Title.Text;
        }

        private void Progress_OnProgressChanged(double count)
        {
            StatusStrip_ProgressBar.Value = (int)(count * 100); // Multiply by 100 because the highest is 1
            ChangeStatusText("Downloading: " + ((int)(count * 100)).ToString() + "%");
        }

        private void RadioButton_Extensions_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_OGG.Checked)
                extension = YTDownload.Extensions.OGG;
            else if (RadioButton_WebmVideo.Checked)
                extension = YTDownload.Extensions.WebmVideo;
            else if (RadioButton_MP3.Checked)
                extension = YTDownload.Extensions.MP3;
            else if (RadioButton_MP4.Checked)
                extension = YTDownload.Extensions.MP4;
        }

        /***
         * 
         * Methods
         * 
         ***/
        /// <summary>
        /// Initialize Instance of YTDownload Class and Clear ComboBox
        /// </summary>
        private void InitializeInstances()
        {
            ytdown = new();
            ComboBox_Quality.Items.Clear();
            ChangeStatusText("OK");
        }

        /// <summary>
        /// Change StatusStrip_Status.Text
        /// </summary>
        /// <param name="text">Text</param>
        private void ChangeStatusText(string text)
        {
            StatusStrip_Status.Text = text;
        }
    }
}
