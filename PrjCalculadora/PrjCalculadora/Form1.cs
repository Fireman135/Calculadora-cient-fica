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
    public partial class Form1 : Form
    {
        public double v1 = 0, v2 = 0;
        public String op = "";
        public Boolean A = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "9";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            v2 = double.Parse(lblDisplay.Text);
            if (op == "+")
            {
                lblDisplay.Text = (v1 + v2) + "";
            }
            else if (op == "-")
            {
                lblDisplay.Text = (v1 - v2) + "";
            }
            else if (op == "*")
            {
                lblDisplay.Text = (v1 * v2) + "";
            }
            else if (op == "/")
            {
                lblDisplay.Text = (v1 / v2) + "";
            }
            if (!A)
            {
                v1 += v2;
                v2 = v1 - v2;
                v1 -= v2;
                A = true;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(lblDisplay.Text);
            op = "+";
            lblDisplay.Text = "0";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(lblDisplay.Text);
            op = "-";
            lblDisplay.Text = "0";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(lblDisplay.Text);
            op = "*";
            lblDisplay.Text = "0";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(lblDisplay.Text);
            op = "/";
            lblDisplay.Text = "0";
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
        }

        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCientífica novo = new FrmCientífica();
            novo.Show();
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProgramador novo = new FrmProgramador();
            novo.Show();
        }
    }
}
