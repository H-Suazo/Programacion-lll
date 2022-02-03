namespace LP_lll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNumPrimo = new System.Windows.Forms.TextBox();
            this.txtParImpar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(63, 46);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(110, 15);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Ingrese un número:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(348, 46);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(188, 46);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 2;
            // 
            // txtNumPrimo
            // 
            this.txtNumPrimo.Location = new System.Drawing.Point(63, 131);
            this.txtNumPrimo.Name = "txtNumPrimo";
            this.txtNumPrimo.Size = new System.Drawing.Size(149, 23);
            this.txtNumPrimo.TabIndex = 3;
            // 
            // txtParImpar
            // 
            this.txtParImpar.Location = new System.Drawing.Point(63, 91);
            this.txtParImpar.Name = "txtParImpar";
            this.txtParImpar.Size = new System.Drawing.Size(149, 23);
            this.txtParImpar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.txtParImpar);
            this.Controls.Add(this.txtNumPrimo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNum;
        private Button btnProcesar;
        private TextBox txtNumero;
        private TextBox txtNumPrimo;
        private TextBox txtParImpar;
    }
}