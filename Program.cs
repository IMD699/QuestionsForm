using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QuestionsForm;

namespace YourNamespace // غيّر الاسم حسب مشروعك
{
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Enable High DPI awareness for better rendering
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.Run(new Form1()); // أو أي اسم الفورم الرئيسي عندك
        }
    }
}
