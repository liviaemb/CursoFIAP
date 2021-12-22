namespace operadorLogicoOu
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
            this.lblCompra = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtCupom = new System.Windows.Forms.TextBox();
            this.lblCupom = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(69, 34);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(144, 25);
            this.lblCompra.TabIndex = 0;
            this.lblCompra.Text = "Total da compra:";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(254, 34);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(150, 31);
            this.txtCompra.TabIndex = 1;
            // 
            // txtCupom
            // 
            this.txtCupom.Location = new System.Drawing.Point(254, 88);
            this.txtCupom.Name = "txtCupom";
            this.txtCupom.Size = new System.Drawing.Size(150, 31);
            this.txtCupom.TabIndex = 3;
            // 
            // lblCupom
            // 
            this.lblCupom.AutoSize = true;
            this.lblCupom.Location = new System.Drawing.Point(69, 91);
            this.lblCupom.Name = "lblCupom";
            this.lblCupom.Size = new System.Drawing.Size(179, 25);
            this.lblCupom.TabIndex = 2;
            this.lblCupom.Text = "Cupom de desconto:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(112, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(236, 34);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular desconto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 231);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCupom);
            this.Controls.Add(this.lblCupom);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.lblCompra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCompra;
        private TextBox txtCompra;
        private TextBox txtCupom;
        private Label lblCupom;
        private Button btnCalcular;
    }
}