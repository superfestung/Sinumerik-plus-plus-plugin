﻿using System.Windows.Forms;
using NppDemo.Utils;
using Kbg.NppPluginNET;

namespace NppDemo.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            NppFormHelper.RegisterFormIfModeless(this, true);
            FormStyle.ApplyStyle(this, Main.settings.use_npp_styling);
            ThanksWowLinkLabel.LinkColor = ThanksWowLinkLabel.ForeColor; // hidden!
            Title.Text = Title.Text.Replace("X.Y.Z.A", Npp.AssemblyVersionString());
            DebugInfoLabel.Text = DebugInfoLabel.Text.Replace("X.Y.Z", Npp.nppVersionStr);
        }

        private void GitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main.Docs();
        }

        /// <summary>
        /// maybe do something with this link?
        /// </summary>
        private void ThanksWowLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        /// <summary>
        /// Escape key exits the form.
        /// </summary>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Title_Click(object sender, System.EventArgs e)
        {

        }

        private void DebugInfoLabel_Click(object sender, System.EventArgs e)
        {

        }
    }
}
