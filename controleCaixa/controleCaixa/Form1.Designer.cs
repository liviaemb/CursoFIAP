namespace controleCaixa
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
            this.lblTransacao = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbOpcao = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransacao
            // 
            this.lblTransacao.AutoSize = true;
            this.lblTransacao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransacao.ForeColor = System.Drawing.Color.White;
            this.lblTransacao.Location = new System.Drawing.Point(91, 27);
            this.lblTransacao.Name = "lblTransacao";
            this.lblTransacao.Size = new System.Drawing.Size(258, 29);
            this.lblTransacao.TabIndex = 0;
            this.lblTransacao.Text = "Transação desejada:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(107, 79);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(229, 31);
            this.txtValor.TabIndex = 1;
            // 
            // cmbOpcao
            // 
            this.cmbOpcao.FormattingEnabled = true;
            this.cmbOpcao.Items.AddRange(new object[] {
            "Depósito",
            "Saque",
            "Saldo"});
            this.cmbOpcao.Location = new System.Drawing.Point(107, 116);
            this.cmbOpcao.Name = "cmbOpcao";
            this.cmbOpcao.Size = new System.Drawing.Size(229, 33);
            this.cmbOpcao.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(171, 172);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 34);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(425, 228);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cmbOpcao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblTransacao);
            this.Name = "Form1";
            this.Text = "Nubank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTransacao;
        private TextBox txtValor;
        private ComboBox cmbOpcao;
        private Button btnConfirmar;
    }
}