
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
            this.Button_Get = new System.Windows.Forms.Button();
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
            this.RadioButton_OGG = new System.Windows.Forms.RadioButton();
            this.GroupBox_FileExtension = new System.Windows.Forms.GroupBox();
            this.ComboBox_Quality = new System.Windows.Forms.ComboBox();
            this.RadioButton_WebmVideo = new System.Windows.Forms.RadioButton();
            this.Button_Start = new System.Windows.Forms.Button();
            this.GroupBox_FileInfo = new System.Windows.Forms.GroupBox();
            this.TextBox_Artist = new System.Windows.Forms.TextBox();
            this.TextBox_Title = new System.Windows.Forms.TextBox();
            this.Label_Artist = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.GroupBox_FileExtension.SuspendLayout();
            this.GroupBox_FileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_VideoID
            // 
            this.TextBox_VideoID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_VideoID.Location = new System.Drawing.Point(12, 27);
            this.TextBox_VideoID.Name = "TextBox_VideoID";
            this.TextBox_VideoID.PlaceholderText = "https://youtube.com/watch?v=XXxX0Xxx";
            this.TextBox_VideoID.Size = new System.Drawing.Size(360, 23);
            this.TextBox_VideoID.TabIndex = 0;
            // 
            // Button_Get
            // 
            this.Button_Get.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Get.Location = new System.Drawing.Point(378, 27);
            this.Button_Get.Name = "Button_Get";
            this.Button_Get.Size = new System.Drawing.Size(94, 23);
            this.Button_Get.TabIndex = 1;
            this.Button_Get.Text = "Get";
            this.Button_Get.UseVisualStyleBackColor = true;
            this.Button_Get.Click += new System.EventHandler(this.Button_Get_Click);
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
            this.MenuStrip_Help_AboutOfThis.Size = new System.Drawing.Size(143, 22);
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
            this.RadioButton_MP3.Location = new System.Drawing.Point(62, 22);
            this.RadioButton_MP3.Name = "RadioButton_MP3";
            this.RadioButton_MP3.Size = new System.Drawing.Size(49, 19);
            this.RadioButton_MP3.TabIndex = 6;
            this.RadioButton_MP3.TabStop = true;
            this.RadioButton_MP3.Text = "MP3";
            this.RadioButton_MP3.UseVisualStyleBackColor = true;
            this.RadioButton_MP3.CheckedChanged += new System.EventHandler(this.RadioButton_Extensions_CheckedChanged);
            // 
            // RadioButton_MP4
            // 
            this.RadioButton_MP4.AutoSize = true;
            this.RadioButton_MP4.Location = new System.Drawing.Point(117, 22);
            this.RadioButton_MP4.Name = "RadioButton_MP4";
            this.RadioButton_MP4.Size = new System.Drawing.Size(49, 19);
            this.RadioButton_MP4.TabIndex = 7;
            this.RadioButton_MP4.TabStop = true;
            this.RadioButton_MP4.Text = "MP4";
            this.RadioButton_MP4.UseVisualStyleBackColor = true;
            this.RadioButton_MP4.CheckedChanged += new System.EventHandler(this.RadioButton_Extensions_CheckedChanged);
            // 
            // RadioButton_OGG
            // 
            this.RadioButton_OGG.AutoSize = true;
            this.RadioButton_OGG.Location = new System.Drawing.Point(6, 22);
            this.RadioButton_OGG.Name = "RadioButton_OGG";
            this.RadioButton_OGG.Size = new System.Drawing.Size(50, 19);
            this.RadioButton_OGG.TabIndex = 8;
            this.RadioButton_OGG.TabStop = true;
            this.RadioButton_OGG.Text = "OGG";
            this.RadioButton_OGG.UseVisualStyleBackColor = true;
            this.RadioButton_OGG.CheckedChanged += new System.EventHandler(this.RadioButton_Extensions_CheckedChanged);
            // 
            // GroupBox_FileExtension
            // 
            this.GroupBox_FileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_FileExtension.Controls.Add(this.ComboBox_Quality);
            this.GroupBox_FileExtension.Controls.Add(this.RadioButton_WebmVideo);
            this.GroupBox_FileExtension.Controls.Add(this.RadioButton_OGG);
            this.GroupBox_FileExtension.Controls.Add(this.RadioButton_MP4);
            this.GroupBox_FileExtension.Controls.Add(this.RadioButton_MP3);
            this.GroupBox_FileExtension.Location = new System.Drawing.Point(12, 56);
            this.GroupBox_FileExtension.Name = "GroupBox_FileExtension";
            this.GroupBox_FileExtension.Size = new System.Drawing.Size(242, 104);
            this.GroupBox_FileExtension.TabIndex = 9;
            this.GroupBox_FileExtension.TabStop = false;
            this.GroupBox_FileExtension.Text = "File Extension";
            // 
            // ComboBox_Quality
            // 
            this.ComboBox_Quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Quality.FormattingEnabled = true;
            this.ComboBox_Quality.Location = new System.Drawing.Point(6, 72);
            this.ComboBox_Quality.Name = "ComboBox_Quality";
            this.ComboBox_Quality.Size = new System.Drawing.Size(121, 23);
            this.ComboBox_Quality.TabIndex = 11;
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
            this.RadioButton_WebmVideo.CheckedChanged += new System.EventHandler(this.RadioButton_Extensions_CheckedChanged);
            // 
            // Button_Start
            // 
            this.Button_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Start.Enabled = false;
            this.Button_Start.Location = new System.Drawing.Point(378, 56);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(94, 23);
            this.Button_Start.TabIndex = 10;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // GroupBox_FileInfo
            // 
            this.GroupBox_FileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_FileInfo.Controls.Add(this.TextBox_Artist);
            this.GroupBox_FileInfo.Controls.Add(this.TextBox_Title);
            this.GroupBox_FileInfo.Controls.Add(this.Label_Artist);
            this.GroupBox_FileInfo.Controls.Add(this.Label_Title);
            this.GroupBox_FileInfo.Location = new System.Drawing.Point(260, 78);
            this.GroupBox_FileInfo.Name = "GroupBox_FileInfo";
            this.GroupBox_FileInfo.Size = new System.Drawing.Size(212, 158);
            this.GroupBox_FileInfo.TabIndex = 11;
            this.GroupBox_FileInfo.TabStop = false;
            this.GroupBox_FileInfo.Text = "File Info";
            // 
            // TextBox_Artist
            // 
            this.TextBox_Artist.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Artist.Location = new System.Drawing.Point(47, 42);
            this.TextBox_Artist.Name = "TextBox_Artist";
            this.TextBox_Artist.Size = new System.Drawing.Size(159, 20);
            this.TextBox_Artist.TabIndex = 3;
            this.TextBox_Artist.TextChanged += new System.EventHandler(this.TextBox_Artist_TextChanged);
            // 
            // TextBox_Title
            // 
            this.TextBox_Title.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Title.Location = new System.Drawing.Point(47, 18);
            this.TextBox_Title.Name = "TextBox_Title";
            this.TextBox_Title.Size = new System.Drawing.Size(159, 20);
            this.TextBox_Title.TabIndex = 2;
            this.TextBox_Title.TextChanged += new System.EventHandler(this.TextBox_Title_TextChanged);
            // 
            // Label_Artist
            // 
            this.Label_Artist.AutoSize = true;
            this.Label_Artist.Location = new System.Drawing.Point(6, 45);
            this.Label_Artist.Name = "Label_Artist";
            this.Label_Artist.Size = new System.Drawing.Size(41, 15);
            this.Label_Artist.TabIndex = 1;
            this.Label_Artist.Text = "Artist: ";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Location = new System.Drawing.Point(6, 19);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(35, 15);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "Title: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.GroupBox_FileInfo);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.GroupBox_FileExtension);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.Button_Get);
            this.Controls.Add(this.TextBox_VideoID);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(500, 300);
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
            this.GroupBox_FileInfo.ResumeLayout(false);
            this.GroupBox_FileInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_VideoID;
        private System.Windows.Forms.Button Button_Get;
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
        private System.Windows.Forms.RadioButton RadioButton_OGG;
        private System.Windows.Forms.GroupBox GroupBox_FileExtension;
        private System.Windows.Forms.RadioButton RadioButton_WebmVideo;
        private System.Windows.Forms.ComboBox ComboBox_Quality;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.GroupBox GroupBox_FileInfo;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Artist;
        private System.Windows.Forms.TextBox TextBox_Artist;
        private System.Windows.Forms.TextBox TextBox_Title;
    }
}

