using System.Diagnostics;
using System.Security.Principal;

namespace AssaultCubeGameHack
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
            if (IsAdministrator() == false) // 관리자 권한으로 실행되지 않는 경우라면 ..
            {
                try
                {
                    ProcessStartInfo procInfo = new ProcessStartInfo();
                    procInfo.UseShellExecute = true;
                    procInfo.FileName = Application.ExecutablePath;
                    procInfo.WorkingDirectory = Environment.CurrentDirectory;
                    procInfo.Verb = "runas";
                    Process.Start(procInfo);
                }
                catch (Exception ex)
                {
                    // 사용자가 프로그램을 관리자 권한으로 실행하기를 원하지 않을 경우에 대한 처리
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            { // 처음부터 프로그램은 관리자 권한으로 실행되고 있는 경우라면 ..
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            */
        }

        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            if (identity != null)
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            return false;
        }
    }
}