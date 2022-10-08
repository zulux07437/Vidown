using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vidown.Common;

namespace Vidown.Forms
{
    public partial class AboutOfThis : Form
    {
        public AboutOfThis()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabel_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel_GitHub.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://github.com/zulux07437/Vidown");
        }

        private void AboutOfThis_Load(object sender, EventArgs e)
        {
            Label_About.Text = $"{Application.ProductName}_{Application.ProductVersion}\n{Informations.Copyright}";
        }
    }
}
