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
    public partial class FrmProgramador : Form1
    {
        public FrmProgramador()
        {
            InitializeComponent();
        }

        private Boolean D = true;
        private Boolean B = false;
        private Boolean H = false;

        private void btnA_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "A";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "B";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "A";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "A";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || A)
            {
                lblDisplay.Text = "";
                A = false;
            }
            lblDisplay.Text = lblDisplay.Text + "5";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            if (B)
            {
                lblDisplay.Text = Convert.ToString(Convert.ToInt32(lblDisplay.Text, 2), 10).ToUpper();
            }
            else if (H) 
            {
                lblDisplay.Text = Convert.ToString(Convert.ToInt32(lblDisplay.Text, 16), 10).ToUpper();
            }
            D = true;
            B = false;
            H = false;
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            if (!B)
            {
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                if (D)
                {
                    lblDisplay.Text = Convert.ToString(Convert.ToInt32(lblDisplay.Text, 10), 2).ToUpper();
                }
                else if (H)
                {
                    lblDisplay.Text = Convert.ToString(Convert.ToInt32(lblDisplay.Text, 16), 2).ToUpper();
                }
                D = false;
                B = true;
                H = false;
            }
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            if (D)
            {
                lblDisplay.Text = Convert.ToString(Convert.ToInt32(lblDisplay.Text, 10), 16).ToUpper();
            }
            else if (B)
            {
                lblDisplay.Text = Convert.ToString(Convert.ToInt32(lblDisplay.Text, 2), 16).ToUpper();
            }
            D = false;
            B = false;
            H = true;
        }
    }
}
