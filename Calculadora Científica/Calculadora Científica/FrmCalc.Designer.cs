namespace WindowsFormsApplication1
{
    partial class FrmCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnOposto = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnCosseno = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisplay.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblDisplay.Location = new System.Drawing.Point(10, 9);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(286, 32);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnIgual.Location = new System.Drawing.Point(249, 149);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(0);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(48, 72);
            this.btnIgual.TabIndex = 2;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn1.Location = new System.Drawing.Point(57, 149);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 36);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSomar.Location = new System.Drawing.Point(201, 185);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(48, 36);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn7.Location = new System.Drawing.Point(57, 77);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 36);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn4.Location = new System.Drawing.Point(57, 113);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 36);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn8.Location = new System.Drawing.Point(105, 77);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 36);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn5.Location = new System.Drawing.Point(105, 113);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 36);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn9.Location = new System.Drawing.Point(153, 77);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 36);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn2.Location = new System.Drawing.Point(105, 149);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 36);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn6.Location = new System.Drawing.Point(153, 113);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 36);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn3.Location = new System.Drawing.Point(153, 149);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 36);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnSubtrair.Location = new System.Drawing.Point(201, 149);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(48, 36);
            this.btnSubtrair.TabIndex = 13;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnMultiplicar.Location = new System.Drawing.Point(201, 113);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(48, 36);
            this.btnMultiplicar.TabIndex = 14;
            this.btnMultiplicar.Text = "✕";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDividir.Location = new System.Drawing.Point(201, 77);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(0);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(48, 36);
            this.btnDividir.TabIndex = 15;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn0.Location = new System.Drawing.Point(57, 185);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 36);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnInverter.Location = new System.Drawing.Point(249, 113);
            this.btnInverter.Margin = new System.Windows.Forms.Padding(0);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(48, 36);
            this.btnInverter.TabIndex = 17;
            this.btnInverter.Text = "1/x";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRaiz.Location = new System.Drawing.Point(249, 77);
            this.btnRaiz.Margin = new System.Windows.Forms.Padding(0);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(48, 36);
            this.btnRaiz.TabIndex = 18;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnC.Location = new System.Drawing.Point(153, 41);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(48, 36);
            this.btnC.TabIndex = 19;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCE.Location = new System.Drawing.Point(105, 41);
            this.btnCE.Margin = new System.Windows.Forms.Padding(0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(48, 36);
            this.btnCE.TabIndex = 20;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnOposto
            // 
            this.btnOposto.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnOposto.Location = new System.Drawing.Point(201, 41);
            this.btnOposto.Margin = new System.Windows.Forms.Padding(0);
            this.btnOposto.Name = "btnOposto";
            this.btnOposto.Size = new System.Drawing.Size(48, 36);
            this.btnOposto.TabIndex = 21;
            this.btnOposto.Text = "±";
            this.btnOposto.UseVisualStyleBackColor = true;
            this.btnOposto.Click += new System.EventHandler(this.btnOposto_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Arial", 16F);
            this.btnBackspace.Location = new System.Drawing.Point(57, 41);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(48, 36);
            this.btnBackspace.TabIndex = 22;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSeno.Location = new System.Drawing.Point(9, 77);
            this.btnSeno.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(48, 36);
            this.btnSeno.TabIndex = 23;
            this.btnSeno.Text = "sen";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // btnCosseno
            // 
            this.btnCosseno.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCosseno.Location = new System.Drawing.Point(9, 113);
            this.btnCosseno.Margin = new System.Windows.Forms.Padding(0);
            this.btnCosseno.Name = "btnCosseno";
            this.btnCosseno.Size = new System.Drawing.Size(48, 36);
            this.btnCosseno.TabIndex = 24;
            this.btnCosseno.Text = "cos";
            this.btnCosseno.UseVisualStyleBackColor = true;
            this.btnCosseno.Click += new System.EventHandler(this.btnCosseno_Click);
            // 
            // btnTangente
            // 
            this.btnTangente.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTangente.Location = new System.Drawing.Point(9, 149);
            this.btnTangente.Margin = new System.Windows.Forms.Padding(0);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(48, 36);
            this.btnTangente.TabIndex = 25;
            this.btnTangente.Text = "tan";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.btnTangente_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPotencia.Location = new System.Drawing.Point(249, 41);
            this.btnPotencia.Margin = new System.Windows.Forms.Padding(0);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(48, 36);
            this.btnPotencia.TabIndex = 26;
            this.btnPotencia.Text = "x^y";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnVirgula.Location = new System.Drawing.Point(153, 185);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(0);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(48, 36);
            this.btnVirgula.TabIndex = 27;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFactorial.Location = new System.Drawing.Point(9, 185);
            this.btnFactorial.Margin = new System.Windows.Forms.Padding(0);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(48, 36);
            this.btnFactorial.TabIndex = 28;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnPI
            // 
            this.btnPI.Font = new System.Drawing.Font("Calibri", 16F);
            this.btnPI.Location = new System.Drawing.Point(9, 41);
            this.btnPI.Margin = new System.Windows.Forms.Padding(0);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(48, 36);
            this.btnPI.TabIndex = 29;
            this.btnPI.Text = "π";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 230);
            this.Controls.Add(this.btnPI);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnTangente);
            this.Controls.Add(this.btnCosseno);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnOposto);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.lblDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCalc";
            this.ShowIcon = false;
            this.Text = "Calculadora Científica";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnOposto;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnCosseno;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnPI;
    }
}

