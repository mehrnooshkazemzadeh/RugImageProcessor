namespace ImageProcessor
{
    partial class FrmError
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmError));
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblError.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.Location = new System.Drawing.Point(126, 22);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(281, 68);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "test";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Location = new System.Drawing.Point(11, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(147, 109);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(121, 34);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.TabStop = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FrmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(441, 171);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}