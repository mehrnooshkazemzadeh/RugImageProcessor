namespace ImageProcessor
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKey.Location = new System.Drawing.Point(133, 34);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(267, 30);
            this.txtKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register key:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Location = new System.Drawing.Point(11, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(86, 91);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(121, 34);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.TabStop = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(223, 91);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(441, 171);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.PictureBox btnRegister;
    }
}