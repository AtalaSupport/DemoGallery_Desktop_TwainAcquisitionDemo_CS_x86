using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace AcquisitionDemo
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            Assembly asm = Assembly.Load("Atalasoft.DotTwain");
            this.lblVersion.Text = "Version: " + asm.GetName().Version.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.atalasoft.com");
        }

        private void apiRefLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.atalasoft.com/Support/APIs-Dev-Guides");
        }

        private void demoGalleryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.atalasoft.com/Support/Sample-Applications");
        }

        private void downloadDotImageLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.atalasoft.com/BeginDownload");
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Built with DotImage 11.5");
        }
    }
}

