﻿using B24BusynessProcess.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24BusynessProcess.Forms.ConfigForm
{
    internal class DoneEventArgs
    {
        public string? WebHook = null;
    }

    internal partial class ConfigForm : Form
    {
        public delegate void DoneEventHandler(object sender, DoneEventArgs e);

        public event DoneEventHandler? Done;

        public ConfigForm(in Config.Config config)
        {
            InitializeComponent();

            HookInput.Text = config.WebHook;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveConfigButton_Click(object sender, EventArgs e)
        {
            Done?.Invoke(this, new DoneEventArgs()
            {
                WebHook = HookInput.Text
            });

            Close();
        }
    }
}
