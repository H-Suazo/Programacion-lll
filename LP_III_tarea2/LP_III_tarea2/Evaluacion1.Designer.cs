namespace LP_III_tarea2
{
    partial class Evaluacion1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtVentasPM = new System.Windows.Forms.TextBox();
            this.dTPFNac = new System.Windows.Forms.DateTimePicker();
            this.dTPFIng = new System.Windows.Forms.DateTimePicker();
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los siguientes datos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ventas promedio mensuales: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de ingreso a la empresa:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(215, 111);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(116, 23);
            this.txtSueldo.TabIndex = 5;
            // 
            // txtVentasPM
            // 
            this.txtVentasPM.Location = new System.Drawing.Point(552, 111);
            this.txtVentasPM.Name = "txtVentasPM";
            this.txtVentasPM.Size = new System.Drawing.Size(106, 23);
            this.txtVentasPM.TabIndex = 6;
            // 
            // dTPFNac
            // 
            this.dTPFNac.Location = new System.Drawing.Point(289, 165);
            this.dTPFNac.Name = "dTPFNac";
            this.dTPFNac.Size = new System.Drawing.Size(200, 23);
            this.dTPFNac.TabIndex = 7;
            // 
            // dTPFIng
            // 
            this.dTPFIng.Location = new System.Drawing.Point(337, 222);
            this.dTPFIng.Name = "dTPFIng";
            this.dTPFIng.Size = new System.Drawing.Size(200, 23);
            this.dTPFIng.TabIndex = 8;
            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularSueldo.Location = new System.Drawing.Point(163, 287);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(140, 43);
            this.btnCalcularSueldo.TabIndex = 9;
            this.btnCalcularSueldo.Text = "Calcular sueldo";
            this.btnCalcularSueldo.UseVisualStyleBackColor = true;
            this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);
            // 
            // Evaluacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Controls.Add(this.dTPFIng);
            this.Controls.Add(this.dTPFNac);
            this.Controls.Add(this.txtVentasPM);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Evaluacion1";
            this.Text = "Evaluacion1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSueldo;
        private TextBox txtVentasPM;
        private DateTimePicker dTPFNac;
        private DateTimePicker dTPFIng;
        private Button btnCalcularSueldo;
    }
}