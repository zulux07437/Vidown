
namespace Vidown
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_VideoID = new System.Windows.Forms.TextBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_File_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Help_AboutOfThis = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStrip_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.RadioButton_MP3 = new System.Windows.Forms.RadioButton();
            this.RadioButton_MP4 = new System.Windows.Forms.RadioButton();
            this.RadioButton_WebmAudio = new System.Windows.Forms.RadioButton();
            this.GroupBox_FileExtension = new System.Windows.Forms.GroupBox();
            this.RadioButton_WebmVideo = new System.Windows.Forms.RadioButton();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.GroupBox_FileExtension.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_URL
            // 
            this.TextBox_VideoID.Location = new System.Drawing.Point(12, 27);
            this.TextBox_VideoID.Name = "TextBox_URL";
            this.TextBox_VideoID.PlaceholderText = "https://youtube.com/watch?v=XXxX0Xxx";
            this.TextBox_VideoID.Size = new System.Drawing.Size(360, 23);
            this.TextBox_VideoID.TabIndex = 0;
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(378, 27);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(94, 23);
            this.Button_Start.TabIndex = 1;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_File,
            this.MenuStrip_Help});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(484, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuStrip_File
            // 
            this.MenuStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_File_Settings});
            this.MenuStrip_File.Name = "MenuStrip_File";
            this.MenuStrip_File.Size = new System.Drawing.Size(37, 20);
            this.MenuStrip_File.Text = "File";
            // 
            // MenuStrip_File_Settings
            // 
            this.MenuStrip_File_Settings.Name = "MenuStrip_File_Settings";
            this.MenuStrip_File_Settings.Size = new System.Drawing.Size(116, 22);
            this.MenuStrip_File_Settings.Text = "Settings";
            this.MenuStrip_File_Settings.Click += new System.EventHandler(this.MenuStrip_File_Settings_Click);
            // 
            // MenuStrip_Help
            // 
            this.MenuStrip_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Help_AboutOfThis});
            this.MenuStrip_Help.Name = "MenuStrip_Help";
            this.MenuStrip_Help.Size = new System.Drawing.Size(44, 20);
            this.MenuStrip_Help.Text = "Help";
            // 
            // MenuStrip_Help_AboutOfThis
            // 
            this.MenuStrip_Help_AboutOfThis.Name = "MenuStrip_Help_AboutOfThis";
            this.MenuStrip_Help_AboutOfThis.Size = new System.Drawing.Size(180, 22);
            this.MenuStrip_Help_AboutOfThis.Text = "About of this";
            this.MenuStrip_Help_AboutOfThis.Click += new System.EventHandler(this.MenuStrip_Help_AboutOfThis_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip_Status,
            this.StatusStrip_ProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 239);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(484, 22);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStrip_Status
            // 
            this.StatusStrip_Status.Name = "StatusStrip_Status";
            this.StatusStrip_Status.Size = new System.Drawing.Size(117, 17);
            this.StatusStrip_Status.Spring = true;
            this.StatusStrip_Status.Text = "Initial";
            this.StatusStrip_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusStrip_ProgressBar
            // 
            this.StatusStrip_ProgressBar.Name = "StatusStrip_ProgressBar";
            this.StatusStrip_ProgressBar.Size = new System.Drawing.Size(350, 16);
            // 
            // RadioButton_MP3
            // 
            this.RadioButton_MP3.AutoSize = true;
            this.RadioButton_MP3.Checked = true;
            this.RadioButton_MP3.Location = new System.Drawing.Point(143, 22);
            this.RadioButton_MP3.Name = "RadioButton_MP3";
            this.RadioButton_MP3.Size = new System.Drawing.Size(49, 19);
            this.RadioButton_MP3.TabIndex = 6;
            this.RadioButton_MP3.TabStop = true;
            this.RadioButton_MP3.Text = "MP3";
            this.RadioButton_MP3.UseVisualStyleBackColor = true;
            // 
            // RadioButton_MP4
            // 
            this.RadioButton_MP4.AutoSize = true;
            this.RadioButton_MP4.Location = new System.Drawing.Point(157, 47);
            this.RadioButton_MP4.Name = "RadioButton_MP4";
            this.RadioButton_MP4.Size = new System.Drawing.Size(49, 19);
            this.RadioButton_MP4.TabIndex = 7;
            this.RadioButton_MP4.TabStop = true;
            this.RadioButton_MP4.Text = "MP4";
            this.RadioButton_MP4.UseVisualStyleBackColor = true;
            // 
            // RadioButton_WebmAudio
            // 
            this.RadioButton_WebmAudio.AutoSize = true;
            this.RadioButton_WebmAudio.Location = new System.Drawing.Point(6, 22);
            this.RadioButton_WebmAudio.Name = "RadioButton_WebmAudio";
            this.RadioButton_WebmAudio.Size = new System.Drawing.Size(131, 19);
            this.RadioButton_WebmAudio.TabIndex = 8;
            this.RadioButton_WebmAudio.TabStop = true;
            this.RadioButton_WebmAudio.Text = "Webm (Audio Only)";
            this.RadioButton_WebmAudio.UseVisualStyleBackColor = true;
            // 
            // GroupBox_FileExtension
            // 
            this.GroupBox_FileExtension.Controls.Add(this.RadioButton_WebmVideo);
            this.GroupBox_FileExtension.Controls.Add(this.RadioButton_WebmAudio);
            this.GroupBox_FileExtension.Controls.Add(this.RadioButton_MP4);
            this.GroupBox_FileExtension.Controls.Add(this.RadioButton_MP3);
            this.GroupBox_FileExtension.Location = new System.Drawing.Point(12, 56);
            this.GroupBox_FileExtension.Name = "GroupBox_FileExtension";
            this.GroupBox_FileExtension.Size = new System.Drawing.Size(242, 151);
            this.GroupBox_FileExtension.TabIndex = 9;
            this.GroupBox_FileExtension.TabStop = false;
            this.GroupBox_FileExtension.Text = "File Extension";
            // 
            // RadioButton_WebmVideo
            // 
            this.RadioButton_WebmVideo.AutoSize = true;
            this.RadioButton_WebmVideo.Location = new System.Drawing.Point(6, 47);
            this.RadioButton_WebmVideo.Name = "RadioButton_WebmVideo";
            this.RadioButton_WebmVideo.Size = new System.Drawing.Size(145, 19);
            this.RadioButton_WebmVideo.TabIndex = 10;
            this.RadioButton_WebmVideo.TabStop = true;
            this.RadioButton_WebmVideo.Text = "Webm (Audio x Video)\r\n";
            this.RadioButton_WebmVideo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.GroupBox_FileExtension);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.TextBox_VideoID);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Vidown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.GroupBox_FileExtension.ResumeLayout(false);
            this.GroupBox_FileExtension.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_VideoID;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_File;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_File_Settings;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Help_AboutOfThis;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Status;
        private System.Windows.Forms.ToolStripProgressBar StatusStrip_ProgressBar;
        private System.Windows.Forms.RadioButton RadioButton_MP3;
        private System.Windows.Forms.RadioButton RadioButton_MP4;
        private System.Windows.Forms.RadioButton RadioButton_WebmAudio;
        private System.Windows.Forms.GroupBox GroupBox_FileExtension;
        private System.Windows.Forms.RadioButton RadioButton_WebmVideo;
    }
}

