using B24Api;
using B24BusynessProcess.Config;

namespace B24BusynessProcess
{
    public partial class B24BusynessProcessForm : Form
    {
        private ConfigForm? configForm = null;
        private readonly Config.Config config;
        private readonly Crm crmApi;

        public B24BusynessProcessForm(Crm crmApi)
        {
            InitializeComponent();

            config = ConfigStorage.Load();
            this.crmApi = crmApi;
            this.crmApi.WebHook = config.WebHook;
        }

        private void ExitMainMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigMainMenuItem_Click(object sender, EventArgs e)
        {
            getConfigForm().Show();
        }

        private ConfigForm getConfigForm()
        {
            if (configForm == null || configForm.IsDisposed)
            {
                configForm = new ConfigForm(config);
            }

            return configForm;
        }

        private async void TestButton_Click(object sender, EventArgs e)
        {
            var message = "";
            (await crmApi.DealList())?.ForEach(
                deal => message += "[" + deal.ID + "] " + deal.TITLE + "\n");
            MessageBox.Show(message);
        }
    }
}