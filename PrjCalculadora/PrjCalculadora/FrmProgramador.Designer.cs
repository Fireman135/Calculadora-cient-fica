namespace PrjCalculadora
{
    partial class FrmProgramador
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
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.Size = new System.Drawing.Size(352, 29);
            // 
            // btnE
            // 
            this.btnE.Enabled = false;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnE.Location = new System.Drawing.Point(267, 74);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(45, 35);
            this.btnE.TabIndex = 17;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.Enabled = false;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnD.Location = new System.Drawing.Point(216, 197);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(45, 35);
            this.btnD.TabIndex = 18;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Enabled = false;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnC.Location = new System.Drawing.Point(216, 156);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(45, 35);
            this.btnC.TabIndex = 19;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Enabled = false;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnB.Location = new System.Drawing.Point(216, 115);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(45, 35);
            this.btnB.TabIndex = 20;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnA.Location = new System.Drawing.Point(216, 74);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(45, 35);
            this.btnA.TabIndex = 21;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnHexa
            // 
            this.btnHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHexa.Location = new System.Drawing.Point(267, 197);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(97, 35);
            this.btnHexa.TabIndex = 22;
            this.btnHexa.Text = "Hexadecimal";
            this.btnHexa.UseVisualStyleBackColor = true;
            this.btnHexa.Click += new System.EventHandler(this.btnHexa_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBinario.Location = new System.Drawing.Point(267, 156);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(97, 35);
            this.btnBinario.TabIndex = 23;
            this.btnBinario.Text = "Binário";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDecimal.Location = new System.Drawing.Point(267, 115);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(97, 35);
            this.btnDecimal.TabIndex = 24;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // FrmProgramador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 244);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnHexa);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Name = "FrmProgramador";
            this.Text = "FrmProgramador";
            this.Controls.SetChildIndex(this.btnE, 0);
            this.Controls.SetChildIndex(this.btnD, 0);
            this.Controls.SetChildIndex(this.btnC, 0);
            this.Controls.SetChildIndex(this.btnB, 0);
            this.Controls.SetChildIndex(this.btnA, 0);
            this.Controls.SetChildIndex(this.lblDisplay, 0);
            this.Controls.SetChildIndex(this.btn7, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn6, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.btn8, 0);
            this.Controls.SetChildIndex(this.btn9, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn0, 0);
            this.Controls.SetChildIndex(this.btnSomar, 0);
            this.Controls.SetChildIndex(this.btnDividir, 0);
            this.Controls.SetChildIndex(this.btnIgual, 0);
            this.Controls.SetChildIndex(this.btnMultiplicar, 0);
            this.Controls.SetChildIndex(this.btnSubtrair, 0);
            this.Controls.SetChildIndex(this.btnHexa, 0);
            this.Controls.SetChildIndex(this.btnBinario, 0);
            this.Controls.SetChildIndex(this.btnDecimal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnE;
        public System.Windows.Forms.Button btnD;
        public System.Windows.Forms.Button btnC;
        public System.Windows.Forms.Button btnB;
        public System.Windows.Forms.Button btnA;
        public System.Windows.Forms.Button btnHexa;
        public System.Windows.Forms.Button btnBinario;
        public System.Windows.Forms.Button btnDecimal;
    }
}