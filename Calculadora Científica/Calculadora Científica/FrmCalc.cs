using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmCalc : Form
    {
        private double v1 = 0, v2 = 0;
        private string op = "";
        private bool deveLimpar = false, operadorUsado = false, igualUsado = false;

        public FrmCalc()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "0";
            igualUsado = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "1";
            igualUsado = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "2";
            igualUsado = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "3";
            igualUsado = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "4";
            igualUsado = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "5";
            igualUsado = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "6";
            igualUsado = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "7";
            igualUsado = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "8";
            igualUsado = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0" || deveLimpar)
            {
                lblDisplay.Text = "";
                deveLimpar = false;
            }
            lblDisplay.Text = lblDisplay.Text + "9";
            igualUsado = false;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!lblDisplay.Text.Contains(","))
                lblDisplay.Text += ",";
        }

        private double calc()
        {
            if (op == "+")
                return v1 + v2;
            else if (op == "-")
                return v1 - v2;
            else if (op == "*")
                return v1 * v2;
            else if (op == "/")
                return v1 / v2;
            else if (op == "^")
                return Math.Pow(v1, v2);
            return 0;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!igualUsado)
                v2 = double.Parse(lblDisplay.Text);
            else
                v1 = double.Parse(lblDisplay.Text);
            lblDisplay.Text = calc() + "";
            operadorUsado = false;
			deveLimpar = true;
            igualUsado = true;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (!operadorUsado)
            {
                v1 = double.Parse(lblDisplay.Text);
                operadorUsado = true;
            }
            else
            {
                v2 = double.Parse(lblDisplay.Text);
                v1 = calc();
            }
            lblDisplay.Text = "0";
            op = "+";
            igualUsado = false;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (!operadorUsado)
            {
                v1 = double.Parse(lblDisplay.Text);
                operadorUsado = true;
            }
            else
            {
                v2 = double.Parse(lblDisplay.Text);
                v1 = calc();
            }
            lblDisplay.Text = "0";
            op = "-";
            igualUsado = false;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!operadorUsado)
            {
                v1 = double.Parse(lblDisplay.Text);
                operadorUsado = true;
            }
            else
            {
                v2 = double.Parse(lblDisplay.Text);
                v1 = calc();
            }
            lblDisplay.Text = "0";
            op = "*";
            igualUsado = false;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!operadorUsado)
            {
                v1 = double.Parse(lblDisplay.Text);
                operadorUsado = true;
            }
            else
            {
                v2 = double.Parse(lblDisplay.Text);
                v1 = calc();
            }
            lblDisplay.Text = "0";
            op = "/";
            igualUsado = false;
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (!operadorUsado)
            {
                v1 = double.Parse(lblDisplay.Text);
                operadorUsado = true;
            }
            else
            {
                v2 = double.Parse(lblDisplay.Text);
                v1 = calc();
            }
            lblDisplay.Text = "0";
            op = "^";
            igualUsado = false;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Math.Sqrt(double.Parse(lblDisplay.Text)) + "";
            deveLimpar = true;
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = 1 / double.Parse(lblDisplay.Text) + "";
            deveLimpar = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            v1 = 0;
            v2 = 0;
            op = "";
            deveLimpar = false;
            operadorUsado = false;
            igualUsado = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnOposto_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = -double.Parse(lblDisplay.Text) + "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (!deveLimpar)
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            if (lblDisplay.Text == "")
                lblDisplay.Text = "0";
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Math.Round(Math.Sin(double.Parse(lblDisplay.Text) * Math.PI / 180), 9) + "";
            deveLimpar = true;
        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Math.Round(Math.Cos(double.Parse(lblDisplay.Text) * Math.PI / 180), 9) + "";
            deveLimpar = true;
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Math.Round(Math.Tan(double.Parse(lblDisplay.Text) * Math.PI / 180), 9) + "";
            deveLimpar = true;
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = Math.PI + "";
            deveLimpar = true;
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if (double.Parse(lblDisplay.Text) % 1 != 0 || double.Parse(lblDisplay.Text) < 1)
            {
                lblDisplay.Text = MathNet.Numerics.SpecialFunctions.Gamma(double.Parse(lblDisplay.Text) + 1) + "";
            }
            else if (double.Parse(lblDisplay.Text) <= 170)
            {
                for (double i = double.Parse(lblDisplay.Text) - 1; i > 1; i--)
                {
                    lblDisplay.Text = double.Parse(lblDisplay.Text) * i + "";
                }
            }
            else
            {
                lblDisplay.Text = "∞";
            }
            deveLimpar = true;
        }
    }
}