using B24BusynessProcess.Config;

namespace B24BusynessProcess
{
    public partial class B24BusynessProcessForm : Form
    {
        private ConfigForm? configForm = null;
        private Config.Config config;

        public B24BusynessProcessForm()
        {
            InitializeComponent();

            config = ConfigStorage.Load();
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

        private void TestButton_Click(object sender, EventArgs e)
        {
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) => true;

            var client = new HttpClient(handler);
            client.BaseAddress = new Uri(config.WebHook);
            var response = client.GetAsync("crm.deal.list").Result;
            MessageBox.Show(response.Content.ReadAsStringAsync().Result);
        }
    }
}