using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjCalculadora
{
    public partial class FrmCientífica : Form1
    {
        public FrmCientífica()
        {
            InitializeComponent();
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Math.Sin(double.Parse(lblDisplay.Text) * Math.PI / 180) + "";
        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Math.Cos(double.Parse(lblDisplay.Text) * Math.PI / 180) + "";
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Math.Tan(double.Parse(lblDisplay.Text) * Math.PI / 180) + "";
        }

        private void btnRaiz2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Math.Sqrt(double.Parse(lblDisplay.Text)) + "";
        }
    }
}
