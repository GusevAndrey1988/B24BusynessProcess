using B24BusynessProcess.Forms.B24BusynessProcessForm;

namespace B24BusynessProcess
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new B24BusynessProcessForm(new B24Api.Crm()));
        }
    }
}