using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Markup;

namespace ImageProcessor.Tools
{
    public class RegisterTools
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        //Creating a function that uses the API function...  
        public static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        public static bool CheckInternetConnection()
        {
            bool result = true;
            while (!IsConnectedToInternet())
            {
                if (MessageBox.Show("Check and turn on your internet connection and try again", "Warning", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                {
                    result =false;
                    break;
                }
            }
            return result;
        }
        public   static string GetMACAddress()
        {
            var objMOS = new ManagementObjectSearcher("Select * FROM Win32_NetworkAdapterConfiguration");
            var objMOC = objMOS.Get();
            string macAddress = String.Empty;
            foreach (ManagementObject objMO in objMOC)
            {
                object tempMacAddrObj = objMO["MacAddress"];

                if (tempMacAddrObj == null) //Skip objects without a MACAddress
                {
                    continue;
                }
                if (macAddress == String.Empty) // only return MAC Address from first card that has a MAC Address
                {
                    macAddress = tempMacAddrObj.ToString();
                }
                objMO.Dispose();
            }
            macAddress = macAddress.Replace(":", "");
            return macAddress;
        }

        public static void WriteToWindowsRegistry(string registeryPath , Dictionary<string ,object> values)
        {
            var key = Registry.CurrentUser.CreateSubKey(registeryPath);
            foreach (var item in values.Keys)
            {
                key.SetValue(item, values[item]);

            }
            key.Close();
        }
    }
}
