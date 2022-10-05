
namespace Vidown.Forms
{
    partial class AboutOfThis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_OK = new System.Windows.Forms.Button();
            this.Label_About = new System.Windows.Forms.Label();
            this.LinkLabel_GitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(297, 126);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 0;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Label_About
            // 
            this.Label_About.AutoSize = true;
            this.Label_About.Location = new System.Drawing.Point(13, 13);
            this.Label_About.Name = "Label_About";
            this.Label_About.Size = new System.Drawing.Size(181, 30);
            this.Label_About.TabIndex = 1;
            this.Label_About.Text = "Vidown v1.0.0.0 by zulux07437\r\nCopyright @ 2021-2022, HaxLabs";
            // 
            // LinkLabel_GitHub
            // 
            this.LinkLabel_GitHub.AutoSize = true;
            this.LinkLabel_GitHub.Location = new System.Drawing.Point(246, 130);
            this.LinkLabel_GitHub.Name = "LinkLabel_GitHub";
            this.LinkLabel_GitHub.Size = new System.Drawing.Size(45, 15);
            this.LinkLabel_GitHub.TabIndex = 2;
            this.LinkLabel_GitHub.TabStop = true;
            this.LinkLabel_GitHub.Text = "GitHub";
            this.LinkLabel_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_GitHub_LinkClicked);
            // 
            // AboutThis
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.LinkLabel_GitHub);
            this.Controls.Add(this.Label_About);
            this.Controls.Add(this.Button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutThis";
            this.Text = "About of this";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Label Label_About;
        private System.Windows.Forms.LinkLabel LinkLabel_GitHub;
    }
}