using DataAccess.ApiHelper;

namespace SoftwareCenter_Control_Panel_Last_Version_
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
            try
            {
                ApiHelper.InitializeClient();
            }
            catch (Exception)
            {

                throw ;
            }
            
            Application.Run(new FormMain());
        }
    }
}