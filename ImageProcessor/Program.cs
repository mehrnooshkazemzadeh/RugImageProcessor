using ImageProcessor.Models;
using ImageProcessor.Tools;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var key = Registry.CurrentUser.OpenSubKey(Constants.RegistryPath);
            if (key == null || key.GetValue(Constants.RegisterSettingKey) ==null || key.GetValue(Constants.RegisterSettingKey).ToString().Split("/").First() !=RegisterTools.GetMACAddress())
            {
                if (!RegisterTools.CheckInternetConnection()) return;
                if (new FrmRegister().ShowDialog() == DialogResult.Cancel)
                    return;

            }
            if (!RegisterTools.CheckInternetConnection()) return;
            if (BlackListManager.IsMacAddressInBlackList(RegisterTools.GetMACAddress()))
            {
                new FrmError("License is not valid. Please,call the Admin").ShowDialog();
                return;
            }
            Application.Run(new FrmMain());
        }

    

    }
}
