using ImageProcessor.Entities;
using ImageProcessor.Models;
using ImageProcessor.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            txtKey.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace( txtKey.Text))
            {
                MessageBox.Show("Enter register key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var registerContext =new RegisterDbContext())
            {
                RegisterTools.CheckInternetConnection();
                var registery =registerContext.RegisterKeys.Where(x =>x.ProductName == Constants.ProductName && x.Key == txtKey.Text && !x.IsUsed).FirstOrDefault();
                if (registery == null)
                {
                    MessageBox.Show("Incorrect key !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                registery.UsedNumber += 1;
                var macAddress = RegisterTools.GetMACAddress();
                var registerMac = new RegisterKeyMac() { RegisterKeyId = registery.RegisterKeyId, MacAddress = macAddress };
                registerContext.Add(registerMac);
                registerContext.SaveChanges();
                MessageBox.Show("Congradulation! Registered successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var dic = new Dictionary<string, object>();
                dic.Add(Constants.RegisterSettingKey, $"{macAddress}/{Guid.NewGuid()}");
                RegisterTools.WriteToWindowsRegistry(Constants.RegistryPath, dic);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
