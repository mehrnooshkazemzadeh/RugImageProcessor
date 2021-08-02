namespace ImageProcessor
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateFolder = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDestinationBroweser = new System.Windows.Forms.PictureBox();
            this.txtDestination = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExcelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColumns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.excellFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.destinationFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxCamera1 = new System.Windows.Forms.GroupBox();
            this.txtCameraPath1 = new System.Windows.Forms.Label();
            this.btnPathCamera1 = new System.Windows.Forms.PictureBox();
            this.txtFileNewName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCameraOneNumber = new System.Windows.Forms.MaskedTextBox();
            this.chkCamera1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxCamera2 = new System.Windows.Forms.GroupBox();
            this.txtCameraPath2 = new System.Windows.Forms.Label();
            this.btnPathCamera2 = new System.Windows.Forms.PictureBox();
            this.txtCameraTwoNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkCamera2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateFolder)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDestinationBroweser)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxCamera1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPathCamera1)).BeginInit();
            this.gbxCamera2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPathCamera2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.btnCreateFolder);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(576, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Excel";
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateFolder.BackgroundImage")));
            this.btnCreateFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateFolder.Location = new System.Drawing.Point(214, 202);
            this.btnCreateFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(121, 34);
            this.btnCreateFolder.TabIndex = 6;
            this.btnCreateFolder.TabStop = false;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnDestinationBroweser);
            this.groupBox3.Controls.Add(this.txtDestination);
            this.groupBox3.Location = new System.Drawing.Point(12, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 67);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destination:";
            // 
            // btnDestinationBroweser
            // 
            this.btnDestinationBroweser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDestinationBroweser.BackgroundImage")));
            this.btnDestinationBroweser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDestinationBroweser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestinationBroweser.Location = new System.Drawing.Point(135, 15);
            this.btnDestinationBroweser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestinationBroweser.Name = "btnDestinationBroweser";
            this.btnDestinationBroweser.Size = new System.Drawing.Size(55, 50);
            this.btnDestinationBroweser.TabIndex = 6;
            this.btnDestinationBroweser.TabStop = false;
            this.btnDestinationBroweser.Click += new System.EventHandler(this.btnDestinationBroweser_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.AutoSize = true;
            this.txtDestination.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDestination.Location = new System.Drawing.Point(193, 31);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(0, 16);
            this.txtDestination.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtExcelName);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbColumns);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 117);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // txtExcelName
            // 
            this.txtExcelName.AutoSize = true;
            this.txtExcelName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExcelName.ForeColor = System.Drawing.Color.Black;
            this.txtExcelName.Location = new System.Drawing.Point(193, 35);
            this.txtExcelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtExcelName.Name = "txtExcelName";
            this.txtExcelName.Size = new System.Drawing.Size(0, 16);
            this.txtExcelName.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(135, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnExcelBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Excel:";
            // 
            // cmbColumns
            // 
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.Location = new System.Drawing.Point(132, 79);
            this.cmbColumns.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(276, 27);
            this.cmbColumns.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columns:";
            // 
            // excellFileDialog
            // 
            this.excellFileDialog.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Camera Path:";
            // 
            // gbxCamera1
            // 
            this.gbxCamera1.Controls.Add(this.txtCameraPath1);
            this.gbxCamera1.Controls.Add(this.btnPathCamera1);
            this.gbxCamera1.Controls.Add(this.txtFileNewName);
            this.gbxCamera1.Controls.Add(this.label8);
            this.gbxCamera1.Controls.Add(this.txtCameraOneNumber);
            this.gbxCamera1.Controls.Add(this.chkCamera1);
            this.gbxCamera1.Controls.Add(this.label5);
            this.gbxCamera1.Controls.Add(this.label4);
            this.gbxCamera1.Location = new System.Drawing.Point(10, 27);
            this.gbxCamera1.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCamera1.Name = "gbxCamera1";
            this.gbxCamera1.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCamera1.Size = new System.Drawing.Size(550, 129);
            this.gbxCamera1.TabIndex = 6;
            this.gbxCamera1.TabStop = false;
            // 
            // txtCameraPath1
            // 
            this.txtCameraPath1.AutoSize = true;
            this.txtCameraPath1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCameraPath1.ForeColor = System.Drawing.Color.Black;
            this.txtCameraPath1.Location = new System.Drawing.Point(192, 40);
            this.txtCameraPath1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCameraPath1.Name = "txtCameraPath1";
            this.txtCameraPath1.Size = new System.Drawing.Size(0, 16);
            this.txtCameraPath1.TabIndex = 7;
            // 
            // btnPathCamera1
            // 
            this.btnPathCamera1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPathCamera1.BackgroundImage")));
            this.btnPathCamera1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPathCamera1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathCamera1.Location = new System.Drawing.Point(134, 24);
            this.btnPathCamera1.Margin = new System.Windows.Forms.Padding(4);
            this.btnPathCamera1.Name = "btnPathCamera1";
            this.btnPathCamera1.Size = new System.Drawing.Size(55, 50);
            this.btnPathCamera1.TabIndex = 6;
            this.btnPathCamera1.TabStop = false;
            this.btnPathCamera1.Click += new System.EventHandler(this.btnDestinationBroweser_Click);
            // 
            // txtFileNewName
            // 
            this.txtFileNewName.Enabled = false;
            this.txtFileNewName.Location = new System.Drawing.Point(292, 83);
            this.txtFileNewName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileNewName.Name = "txtFileNewName";
            this.txtFileNewName.Size = new System.Drawing.Size(220, 27);
            this.txtFileNewName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "File Name:";
            // 
            // txtCameraOneNumber
            // 
            this.txtCameraOneNumber.Location = new System.Drawing.Point(131, 83);
            this.txtCameraOneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCameraOneNumber.Mask = "00";
            this.txtCameraOneNumber.Name = "txtCameraOneNumber";
            this.txtCameraOneNumber.Size = new System.Drawing.Size(58, 27);
            this.txtCameraOneNumber.TabIndex = 1;
            this.txtCameraOneNumber.TextChanged += new System.EventHandler(this.txtCameraOneNumber_TextChanged);
            // 
            // chkCamera1
            // 
            this.chkCamera1.AutoSize = true;
            this.chkCamera1.Checked = true;
            this.chkCamera1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCamera1.Location = new System.Drawing.Point(0, 1);
            this.chkCamera1.Margin = new System.Windows.Forms.Padding(4);
            this.chkCamera1.Name = "chkCamera1";
            this.chkCamera1.Size = new System.Drawing.Size(96, 23);
            this.chkCamera1.TabIndex = 7;
            this.chkCamera1.Text = "Camera 1";
            this.chkCamera1.UseVisualStyleBackColor = true;
            this.chkCamera1.CheckedChanged += new System.EventHandler(this.chkCamera1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pic Number:";
            // 
            // gbxCamera2
            // 
            this.gbxCamera2.Controls.Add(this.txtCameraPath2);
            this.gbxCamera2.Controls.Add(this.btnPathCamera2);
            this.gbxCamera2.Controls.Add(this.txtCameraTwoNumber);
            this.gbxCamera2.Controls.Add(this.label6);
            this.gbxCamera2.Controls.Add(this.chkCamera2);
            this.gbxCamera2.Controls.Add(this.label7);
            this.gbxCamera2.Location = new System.Drawing.Point(10, 157);
            this.gbxCamera2.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCamera2.Name = "gbxCamera2";
            this.gbxCamera2.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCamera2.Size = new System.Drawing.Size(550, 133);
            this.gbxCamera2.TabIndex = 6;
            this.gbxCamera2.TabStop = false;
            // 
            // txtCameraPath2
            // 
            this.txtCameraPath2.AutoSize = true;
            this.txtCameraPath2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCameraPath2.ForeColor = System.Drawing.Color.Black;
            this.txtCameraPath2.Location = new System.Drawing.Point(192, 45);
            this.txtCameraPath2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCameraPath2.Name = "txtCameraPath2";
            this.txtCameraPath2.Size = new System.Drawing.Size(0, 16);
            this.txtCameraPath2.TabIndex = 7;
            // 
            // btnPathCamera2
            // 
            this.btnPathCamera2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPathCamera2.BackgroundImage")));
            this.btnPathCamera2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPathCamera2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathCamera2.Location = new System.Drawing.Point(131, 27);
            this.btnPathCamera2.Margin = new System.Windows.Forms.Padding(4);
            this.btnPathCamera2.Name = "btnPathCamera2";
            this.btnPathCamera2.Size = new System.Drawing.Size(55, 50);
            this.btnPathCamera2.TabIndex = 6;
            this.btnPathCamera2.TabStop = false;
            this.btnPathCamera2.Click += new System.EventHandler(this.btnDestinationBroweser_Click);
            // 
            // txtCameraTwoNumber
            // 
            this.txtCameraTwoNumber.Location = new System.Drawing.Point(131, 91);
            this.txtCameraTwoNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCameraTwoNumber.Mask = "00";
            this.txtCameraTwoNumber.Name = "txtCameraTwoNumber";
            this.txtCameraTwoNumber.Size = new System.Drawing.Size(58, 27);
            this.txtCameraTwoNumber.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pic Number:";
            // 
            // chkCamera2
            // 
            this.chkCamera2.AutoSize = true;
            this.chkCamera2.Checked = true;
            this.chkCamera2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCamera2.Location = new System.Drawing.Point(0, 0);
            this.chkCamera2.Margin = new System.Windows.Forms.Padding(4);
            this.chkCamera2.Name = "chkCamera2";
            this.chkCamera2.Size = new System.Drawing.Size(96, 23);
            this.chkCamera2.TabIndex = 7;
            this.chkCamera2.Text = "Camera 2";
            this.chkCamera2.UseVisualStyleBackColor = true;
            this.chkCamera2.CheckedChanged += new System.EventHandler(this.chkCamera2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Camera Path:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(136)))));
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.gbxCamera1);
            this.groupBox4.Controls.Add(this.gbxCamera2);
            this.groupBox4.Location = new System.Drawing.Point(3, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 345);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Camera Managing";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(165, 301);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(288, 301);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(574, 592);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateFolder)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDestinationBroweser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxCamera1.ResumeLayout(false);
            this.gbxCamera1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPathCamera1)).EndInit();
            this.gbxCamera2.ResumeLayout(false);
            this.gbxCamera2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPathCamera2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog excellFileDialog;
        private System.Windows.Forms.ComboBox cmbColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderBrowser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxCamera1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCamera1;
        private System.Windows.Forms.GroupBox gbxCamera2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkCamera2;
        private System.Windows.Forms.MaskedTextBox txtCameraOneNumber;
        private System.Windows.Forms.MaskedTextBox txtCameraTwoNumber;
        private System.Windows.Forms.TextBox txtFileNewName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtExcelName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox btnDestinationBroweser;
        private System.Windows.Forms.Label txtDestination;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox btnCreateFolder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox btnPathCamera1;
        private System.Windows.Forms.Label txtCameraPath1;
        private System.Windows.Forms.Label txtCameraPath2;
        private System.Windows.Forms.PictureBox btnPathCamera2;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.PictureBox btnCancel;
    }
}

