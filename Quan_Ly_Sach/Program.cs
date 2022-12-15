namespace Quan_Ly_Sach
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

            Application.Run(new Quản_lí_kho());


            //Application.Run(new Người_sử_dụng());

            //Application.Run(new TinhLuongcs());

        }
    }
}