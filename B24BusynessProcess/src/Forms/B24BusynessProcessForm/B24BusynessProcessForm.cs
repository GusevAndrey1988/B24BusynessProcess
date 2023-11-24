using B24Api.Crm;
using B24Api.Crm.SmartProcess;
using B24BusynessProcess.Config;
using B24BusynessProcess.Forms.ConfigForm;

namespace B24BusynessProcess.Forms.B24BusynessProcessForm
{
    public partial class B24BusynessProcessForm : Form
    {
        private ConfigForm.ConfigForm? configForm = null;
        private readonly Config.Config config;
        private readonly SmartProcessResource smartProcessResource;

        public B24BusynessProcessForm()
        {
            InitializeComponent();

            config = ConfigStorage.Load();
            smartProcessResource = new SmartProcessResource(new B24ApiGetway(config.WebHook), 181);
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
            var fields = await smartProcessResource.Fields();
            await Task.Run(() =>
            {
                MessageBox.Show(fields.First().Title);
            });
        }

        private void ConfigForm_Done(object sender, DoneEventArgs e)
        {
            config.WebHook = e.WebHook ?? "";

            ConfigStorage.Save(config);
        }
    }
}