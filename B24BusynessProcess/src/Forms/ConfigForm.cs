using B24BusynessProcess.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B24BusynessProcess
{
    internal partial class ConfigForm : Form
    {
        private Config.Config config;

        public ConfigForm(Config.Config config)
        {
            InitializeComponent();
            this.config = config;

            HookInput.Text = config.WebHook;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveConfigButton_Click(object sender, EventArgs e)
        {
            config.WebHook = HookInput.Text;
            ConfigStorage.Save(config);
            Close();
        }
    }
}
