namespace MediaGasolina
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
            this.lblKmInicial = new System.Windows.Forms.Label();
            this.txtKmI = new System.Windows.Forms.TextBox();
            this.txtKmF = new System.Windows.Forms.TextBox();
            this.lblKmFinal = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKmInicial
            // 
            this.lblKmInicial.AutoSize = true;
            this.lblKmInicial.Location = new System.Drawing.Point(241, 38);
            this.lblKmInicial.Name = "lblKmInicial";
            this.lblKmInicial.Size = new System.Drawing.Size(189, 25);
            this.lblKmInicial.TabIndex = 0;
            this.lblKmInicial.Text = "Quilometragem inicial:";
            // 
            // txtKmI
            // 
            this.txtKmI.Location = new System.Drawing.Point(200, 66);
            this.txtKmI.Name = "txtKmI";
            this.txtKmI.Size = new System.Drawing.Size(295, 31);
            this.txtKmI.TabIndex = 1;
            // 
            // txtKmF
            // 
            this.txtKmF.Location = new System.Drawing.Point(200, 140);
            this.txtKmF.Name = "txtKmF";
            this.txtKmF.Size = new System.Drawing.Size(295, 31);
            this.txtKmF.TabIndex = 3;
            // 
            // lblKmFinal
            // 
            this.lblKmFinal.AutoSize = true;
            this.lblKmFinal.Location = new System.Drawing.Point(241, 112);
            this.lblKmFinal.Name = "lblKmFinal";
            this.lblKmFinal.Size = new System.Drawing.Size(179, 25);
            this.lblKmFinal.TabIndex = 2;
            this.lblKmFinal.Text = "Quilometragem final:";
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(200, 221);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(295, 31);
            this.txtLitros.TabIndex = 5;
            // 
            // lblGasolina
            // 
            this.lblGasolina.AutoSize = true;
            this.lblGasolina.Location = new System.Drawing.Point(241, 193);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(254, 25);
            this.lblGasolina.TabIndex = 4;
            this.lblGasolina.Text = "Litros de gasolina abastecidos:";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(219, 273);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(251, 34);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "Calcular Km/L";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(250, 328);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 474);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblGasolina);
            this.Controls.Add(this.txtKmF);
            this.Controls.Add(this.lblKmFinal);
            this.Controls.Add(this.txtKmI);
            this.Controls.Add(this.lblKmInicial);
            this.Name = "Form1";
            this.Text = "Quilometragem por litro ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKmInicial;
        private TextBox txtKmI;
        private TextBox txtKmF;
        private Label lblKmFinal;
        private TextBox txtLitros;
        private Label lblGasolina;
        private Button btnCalculo;
        private Label lblResultado;
    }
}