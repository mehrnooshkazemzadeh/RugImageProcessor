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
    public partial class FrmError : Form
    {
        public FrmError(string errorMessage)
        {
            InitializeComponent();
            lblError.Text = errorMessage;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
