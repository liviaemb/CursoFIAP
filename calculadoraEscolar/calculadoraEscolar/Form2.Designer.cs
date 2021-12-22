namespace calculadoraEscolar
{
    partial class Form2
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
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblAulas = new System.Windows.Forms.Label();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.lblAssistidas = new System.Windows.Forms.Label();
            this.txtAssistidas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(208, 18);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(195, 25);
            this.lblNotas.TabIndex = 0;
            this.lblNotas.Text = "Digite suas duas notas:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(177, 68);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(150, 31);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(353, 68);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(150, 31);
            this.txtN2.TabIndex = 2;
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.Location = new System.Drawing.Point(177, 136);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(123, 25);
            this.lblAulas.TabIndex = 3;
            this.lblAulas.Text = "Total de aulas:";
            // 
            // txtAulas
            // 
            this.txtAulas.Location = new System.Drawing.Point(353, 136);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(150, 31);
            this.txtAulas.TabIndex = 4;
            // 
            // lblAssistidas
            // 
            this.lblAssistidas.AutoSize = true;
            this.lblAssistidas.Location = new System.Drawing.Point(177, 217);
            this.lblAssistidas.Name = "lblAssistidas";
            this.lblAssistidas.Size = new System.Drawing.Size(139, 25);
            this.lblAssistidas.TabIndex = 5;
            this.lblAssistidas.Text = "Aulas assistidas:";
            // 
            // txtAssistidas
            // 
            this.txtAssistidas.Location = new System.Drawing.Point(353, 211);
            this.txtAssistidas.Name = "txtAssistidas";
            this.txtAssistidas.Size = new System.Drawing.Size(150, 31);
            this.txtAssistidas.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(177, 294);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(326, 34);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(314, 369);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAssistidas);
            this.Controls.Add(this.lblAssistidas);
            this.Controls.Add(this.txtAulas);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblNotas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNotas;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label lblAulas;
        private TextBox txtAulas;
        private Label lblAssistidas;
        private TextBox txtAssistidas;
        private Button btnCalcular;
        private Label lblResultado;
    }
}