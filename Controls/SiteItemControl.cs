﻿    using System.Windows.Forms;
using CompatCheckAndMigrate.Helpers;

namespace CompatCheckAndMigrate.Controls
{
    public partial class SiteItemControl : UserControl
    {
        private readonly string _hostname;

        public SiteItemControl(string sitename, bool success)
        {
            InitializeComponent();
            _hostname = "http://" + sitename + ".azurewebsites.net";
            siteLink.Text = _hostname;
            SiteNameLabel.Text = sitename;
            if (success)
            {
                siteStatusBox.Image = Properties.Resources.OK;
            }
            else
            {
                siteStatusBox.Image = Properties.Resources.Error;
                siteLink.Enabled = false;
            }
        }

        private void siteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (siteLink.Enabled)
            {
                Helper.OpenWebLink(_hostname);
            }
        }
    }
}
