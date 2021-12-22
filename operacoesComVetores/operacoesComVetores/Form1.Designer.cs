namespace operacoesComVetores
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
            this.btnTamanho = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.btnBinaria = new System.Windows.Forms.Button();
            this.btnIndice = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTamanho
            // 
            this.btnTamanho.Location = new System.Drawing.Point(49, 51);
            this.btnTamanho.Name = "btnTamanho";
            this.btnTamanho.Size = new System.Drawing.Size(372, 31);
            this.btnTamanho.TabIndex = 0;
            this.btnTamanho.Text = "Tamanho do array";
            this.btnTamanho.UseVisualStyleBackColor = true;
            this.btnTamanho.Click += new System.EventHandler(this.btnTamanho_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(49, 100);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(372, 31);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar o array";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(49, 147);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(372, 31);
            this.btnInverter.TabIndex = 2;
            this.btnInverter.Text = "Inverter o array";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // btnBinaria
            // 
            this.btnBinaria.Location = new System.Drawing.Point(49, 193);
            this.btnBinaria.Name = "btnBinaria";
            this.btnBinaria.Size = new System.Drawing.Size(372, 31);
            this.btnBinaria.TabIndex = 3;
            this.btnBinaria.Text = "Busca binária";
            this.btnBinaria.UseVisualStyleBackColor = true;
            this.btnBinaria.Click += new System.EventHandler(this.btnBinaria_Click);
            // 
            // btnIndice
            // 
            this.btnIndice.Location = new System.Drawing.Point(49, 243);
            this.btnIndice.Name = "btnIndice";
            this.btnIndice.Size = new System.Drawing.Size(372, 31);
            this.btnIndice.TabIndex = 4;
            this.btnIndice.Text = "Obtendo um índice";
            this.btnIndice.UseVisualStyleBackColor = true;
            this.btnIndice.Click += new System.EventHandler(this.btnIndice_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 20;
            this.lstResultados.Location = new System.Drawing.Point(49, 303);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(371, 104);
            this.lstResultados.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 444);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnIndice);
            this.Controls.Add(this.btnBinaria);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnTamanho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTamanho;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnBinaria;
        private System.Windows.Forms.Button btnIndice;
        private System.Windows.Forms.ListBox lstResultados;
    }
}

