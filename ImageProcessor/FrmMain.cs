using BaseProject.Tools;
using ImageProcessor.Models;
using ImageProcessor.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class FrmMain : Form
    {
        private ExcelManager excelWorker;
        public FrmMain()
        {
            InitializeComponent();
            excelWorker = new ExcelManager();
        
        }

        private void btnExcelBrowser_Click(object sender, EventArgs e)
        {
            if (excellFileDialog.ShowDialog() == DialogResult.OK)
            {
                cmbColumns.Items.Clear();
                cmbColumns.Items.Add("---select---");
                cmbColumns.SelectedIndex = 0;
                if (!string.IsNullOrWhiteSpace(excellFileDialog.FileName))
                {
                    txtExcelName.Text = excellFileDialog.FileName;
                    excelWorker.FileName = excellFileDialog.FileName;
                    foreach (var item in excelWorker.GetColumns())
                    {
                        cmbColumns.Items.Add(item);
                    }
                }
            }
        }

        private void chkCamera1_CheckedChanged(object sender, EventArgs e)
        {
            gbxCamera1.Controls.OfType<Control>().Where(x=>x != sender).ToList().ForEach(x => x.Enabled = chkCamera1.Checked);
        }

        private void chkCamera2_CheckedChanged(object sender, EventArgs e)
        {
            gbxCamera2.Controls.OfType<Control>().Where(x => x != sender).ToList().ForEach(x => x.Enabled = chkCamera1.Checked);

        }
        private void btnDestinationBroweser_Click(object sender, EventArgs e)
        {
            if (destinationFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(destinationFolderBrowser.SelectedPath))
                {
                    var senderName = (sender as PictureBox).Name;
                    if (senderName == "btnDestinationBroweser")
                        txtDestination.Text = destinationFolderBrowser.SelectedPath;
                    else if (senderName == "btnPathCamera1")
                        txtCameraPath1.Text = destinationFolderBrowser.SelectedPath;
                    else
                        txtCameraPath2.Text = destinationFolderBrowser.SelectedPath;
                }
            }
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExcelName.Text))
            {
                MessageBox.Show("Choose excel file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbColumns.SelectedIndex <= 0)
            {
                MessageBox.Show("Select a column", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Choose destination path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var values = new List<string>();
            values.Add(txtDestination.Text);
            values.AddRange(excelWorker.GetRowData(cmbColumns.SelectedIndex - 1, cmbColumns.Text));
            new FileManager().WriteToTemp(values, Constants.FileName, Constants.SeperateCharakter);
            foreach (var item in values)
            {
                var path = Path.Combine(txtDestination.Text, item);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            var cameraDatas = new List<CameraData>();
            if (chkCamera1.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCameraPath1.Text))
                {
                    MessageBox.Show("Choose path of Camera 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCameraOneNumber.Text))
                {
                    MessageBox.Show("Choose number of camera 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cameraDatas.Add(new CameraData
                {
                    Files = Directory.GetFiles(txtCameraPath1.Text).Select(x => new CamerafileInfo { FileName = x, IsCopy = false }).OrderBy(x=>x.FileName).ToList(),
                    SelectedFileNumber = int.Parse(txtCameraOneNumber.Text),
                    NewFileName = txtFileNewName.Text
                }) ;
            }
            if (chkCamera2.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCameraPath2.Text))
                {
                    MessageBox.Show("Choose path if Camera 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCameraTwoNumber.Text))
                {
                    MessageBox.Show("Choose number of camera 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cameraDatas.Add(new CameraData
                {
                    Files = Directory.GetFiles(txtCameraPath2.Text).Select(x => new CamerafileInfo { FileName = x, IsCopy = false }).OrderBy(x=>x.FileName).ToList(),
                    SelectedFileNumber = int.Parse(txtCameraTwoNumber.Text)
                });
            }
            var fileManager = new FileManager();
            var values =fileManager.GetfolderNamesFromTempFile(Constants.FileName);
            if (string.IsNullOrWhiteSpace(values))
            {
                MessageBox.Show("Choose excel file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var folderNames = values.Split(Constants.SeperateCharakter);
            var destinationPath = folderNames[0];
            for (int i = 1; i < folderNames.Length; i++)
            {
                var path = Path.Combine(destinationPath, folderNames[i]);
                var remaindPicCamera = cameraDatas.Where(x => !x.IsFinish).ToList();
                if (!remaindPicCamera.Any())
                    break;
                foreach (var camera in remaindPicCamera)
                {
                    for (int j = 0; j < camera.SelectedFileNumber; j++)
                    {
                        var fileCamera =camera.Files.Where(x => !x.IsCopy).FirstOrDefault();
                        if (fileCamera != null)
                        {
                            fileCamera.IsCopy = true;
                            var newFileName = string.IsNullOrWhiteSpace(camera.NewFileName) ? fileManager.GetFileName(fileCamera.FileName) : $"{camera.NewFileName}.{fileManager.GetFileName(fileCamera.FileName).Split(".")[1] }";
                            var destinationFilePath = Path.Combine(path, newFileName);
                            File.Copy(fileCamera.FileName, destinationFilePath, true);
                        }
                        else
                        {
                            camera.IsFinish = true;
                            break;

                        }
                    }
                }
            }
            MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void txtCameraOneNumber_TextChanged(object sender, EventArgs e)
        {
            txtFileNewName.Enabled = txtCameraOneNumber.Text == "1";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCameraPath1_TextChanged(object sender, EventArgs e)
        {
            txtCameraOneNumber.Focus();
        }

        private void txtCameraPath2_TextChanged(object sender, EventArgs e)
        {
            txtCameraTwoNumber.Focus();
        }

    
    }
}
