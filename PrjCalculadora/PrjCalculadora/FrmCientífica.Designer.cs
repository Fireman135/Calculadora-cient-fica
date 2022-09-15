namespace PrjCalculadora
{
    partial class FrmCientífica
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
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnRaiz2 = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.btnCosseno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(12, 34);
            this.lblDisplay.Size = new System.Drawing.Size(249, 29);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 75);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 116);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(63, 157);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(114, 157);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(114, 116);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 157);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(63, 75);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(114, 75);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(63, 116);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 198);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(165, 75);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(165, 198);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(114, 198);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(165, 157);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(165, 116);
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(216, 75);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(45, 35);
            this.btnSeno.TabIndex = 16;
            this.btnSeno.Text = "Sen";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // btnRaiz2
            // 
            this.btnRaiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz2.Location = new System.Drawing.Point(216, 198);
            this.btnRaiz2.Name = "btnRaiz2";
            this.btnRaiz2.Size = new System.Drawing.Size(45, 35);
            this.btnRaiz2.TabIndex = 17;
            this.btnRaiz2.Text = "√";
            this.btnRaiz2.UseVisualStyleBackColor = true;
            this.btnRaiz2.Click += new System.EventHandler(this.btnRaiz2_Click);
            // 
            // btnTangente
            // 
            this.btnTangente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangente.Location = new System.Drawing.Point(216, 157);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(45, 35);
            this.btnTangente.TabIndex = 18;
            this.btnTangente.Text = "Tan";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.btnTangente_Click);
            // 
            // btnCosseno
            // 
            this.btnCosseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosseno.Location = new System.Drawing.Point(216, 116);
            this.btnCosseno.Name = "btnCosseno";
            this.btnCosseno.Size = new System.Drawing.Size(45, 35);
            this.btnCosseno.TabIndex = 19;
            this.btnCosseno.Text = "Cos";
            this.btnCosseno.UseVisualStyleBackColor = true;
            this.btnCosseno.Click += new System.EventHandler(this.btnCosseno_Click);
            // 
            // FrmCientífica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 246);
            this.Controls.Add(this.btnCosseno);
            this.Controls.Add(this.btnTangente);
            this.Controls.Add(this.btnRaiz2);
            this.Controls.Add(this.btnSeno);
            this.Name = "FrmCientífica";
            this.Text = "FrmCientífica";
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
            this.Controls.SetChildIndex(this.btnSeno, 0);
            this.Controls.SetChildIndex(this.btnRaiz2, 0);
            this.Controls.SetChildIndex(this.btnTangente, 0);
            this.Controls.SetChildIndex(this.btnCosseno, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnRaiz2;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.Button btnCosseno;
    }
}