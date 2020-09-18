namespace App_Form
{
    partial class Form1
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblDistanciaFinal = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtDistanciaInicial = new System.Windows.Forms.TextBox();
            this.txtDistanciaFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(175, 101);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(82, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "DIstância Inicial";
            // 
            // lblDistanciaFinal
            // 
            this.lblDistanciaFinal.AutoSize = true;
            this.lblDistanciaFinal.Location = new System.Drawing.Point(175, 133);
            this.lblDistanciaFinal.Name = "lblDistanciaFinal";
            this.lblDistanciaFinal.Size = new System.Drawing.Size(76, 13);
            this.lblDistanciaFinal.TabIndex = 1;
            this.lblDistanciaFinal.Text = "Distância Final";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(302, 255);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(109, 25);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // txtDistanciaInicial
            // 
            this.txtDistanciaInicial.Location = new System.Drawing.Point(263, 98);
            this.txtDistanciaInicial.Name = "txtDistanciaInicial";
            this.txtDistanciaInicial.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaInicial.TabIndex = 3;
            // 
            // txtDistanciaFinal
            // 
            this.txtDistanciaFinal.Location = new System.Drawing.Point(263, 133);
            this.txtDistanciaFinal.Name = "txtDistanciaFinal";
            this.txtDistanciaFinal.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaFinal.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(241, 184);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 38);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDistanciaFinal);
            this.Controls.Add(this.txtDistanciaInicial);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDistanciaFinal);
            this.Controls.Add(this.lblInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblDistanciaFinal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtDistanciaInicial;
        private System.Windows.Forms.TextBox txtDistanciaFinal;
        private System.Windows.Forms.Button btnCalcular;
    }
}

