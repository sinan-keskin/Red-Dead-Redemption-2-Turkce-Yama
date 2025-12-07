using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Red_Dead_Redemption_2_Türkçe_Yama
{
    internal static class Program
    {
        private const string REG_PATH = @"Software\RDR2CeviriAraci";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string gamePath = LoadGamePath();

            if (!string.IsNullOrEmpty(gamePath) && Directory.Exists(gamePath))
            {
                Application.Run(new Form2(gamePath));
            }
            else
            {
                Application.Run(new Form1());
            }
        }

        private static string LoadGamePath()
        {
            var key = Registry.CurrentUser.OpenSubKey(REG_PATH);
            if (key != null)
            {
                string value = key.GetValue("GamePath") as string;
                key.Close();
                return value ?? "";
            }
            return "";
        }
    }
}
