
namespace Vidown.Forms
{
    partial class Settings
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
            this.TextBox_OutputPath = new System.Windows.Forms.TextBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabControl_Output = new System.Windows.Forms.TabPage();
            this.Button_OutputPath = new System.Windows.Forms.Button();
            this.Label_OutputPath = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.TabControl_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_OutputPath
            // 
            this.TextBox_OutputPath.Location = new System.Drawing.Point(64, 4);
            this.TextBox_OutputPath.Name = "TextBox_OutputPath";
            this.TextBox_OutputPath.PlaceholderText = "C:\\Users\\User\\Music";
            this.TextBox_OutputPath.Size = new System.Drawing.Size(168, 23);
            this.TextBox_OutputPath.TabIndex = 0;
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(397, 226);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(316, 226);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabControl_Output);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(460, 208);
            this.TabControl.TabIndex = 3;
            // 
            // TabControl_Output
            // 
            this.TabControl_Output.Controls.Add(this.Button_OutputPath);
            this.TabControl_Output.Controls.Add(this.Label_OutputPath);
            this.TabControl_Output.Controls.Add(this.TextBox_OutputPath);
            this.TabControl_Output.Location = new System.Drawing.Point(4, 24);
            this.TabControl_Output.Name = "TabControl_Output";
            this.TabControl_Output.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl_Output.Size = new System.Drawing.Size(452, 180);
            this.TabControl_Output.TabIndex = 0;
            this.TabControl_Output.Text = "Output";
            this.TabControl_Output.UseVisualStyleBackColor = true;
            // 
            // Button_OutputPath
            // 
            this.Button_OutputPath.Location = new System.Drawing.Point(210, 6);
            this.Button_OutputPath.Name = "Button_OutputPath";
            this.Button_OutputPath.Size = new System.Drawing.Size(20, 20);
            this.Button_OutputPath.TabIndex = 2;
            this.Button_OutputPath.Text = "…";
            this.Button_OutputPath.UseVisualStyleBackColor = true;
            this.Button_OutputPath.Click += new System.EventHandler(this.Button_OutputPath_Click);
            // 
            // Label_OutputPath
            // 
            this.Label_OutputPath.AutoSize = true;
            this.Label_OutputPath.Location = new System.Drawing.Point(7, 7);
            this.Label_OutputPath.Name = "Label_OutputPath";
            this.Label_OutputPath.Size = new System.Drawing.Size(51, 15);
            this.Label_OutputPath.TabIndex = 1;
            this.Label_OutputPath.Text = "Save to: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.TabControl.ResumeLayout(false);
            this.TabControl_Output.ResumeLayout(false);
            this.TabControl_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.TextBox TextBox_OutputPath;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabControl_Output;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Label_OutputPath;
        private System.Windows.Forms.Button Button_OutputPath;
    }
}