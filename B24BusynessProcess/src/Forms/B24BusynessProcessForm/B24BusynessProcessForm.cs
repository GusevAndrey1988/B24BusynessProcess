using B24Api;
using B24BusynessProcess.Config;
using B24BusynessProcess.Forms.ConfigForm;

namespace B24BusynessProcess.Forms.B24BusynessProcessForm
{
    public partial class B24BusynessProcessForm : Form
    {
        private ConfigForm.ConfigForm? configForm = null;
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

        private ConfigForm.ConfigForm getConfigForm()
        {
            if (configForm == null || configForm.IsDisposed)
            {
                configForm = new ConfigForm.ConfigForm(config);
                configForm.Done += ConfigForm_Done;
            }

            return configForm;
        }

        private async void TestButton_Click(object sender, EventArgs e)
        {
            CrmEntitiesListTest.Clear();
            (await crmApi.DealList())?.ForEach(
                deal => CrmEntitiesListTest.AddEntity(deal.ID, deal.TITLE));
        }

        private void ConfigForm_Done(object sender, DoneEventArgs e)
        {
            config.WebHook = e.WebHook ?? "";

            ConfigStorage.Save(config);
        }
    }
}