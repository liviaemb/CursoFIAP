namespace tipoTriangulo
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
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.lblZ = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(150, 26);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(68, 25);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "Valor X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(105, 54);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(150, 31);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(105, 141);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(150, 31);
            this.txtY.TabIndex = 3;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(150, 103);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(67, 25);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Valor Y";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(105, 236);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(150, 31);
            this.txtZ.TabIndex = 5;
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(150, 198);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(67, 25);
            this.lblZ.TabIndex = 4;
            this.lblZ.Text = "Valor Z";

            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(124, 294);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(112, 34);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnVerificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 415);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Triângulos ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblX;
        private TextBox txtX;
        private TextBox txtY;
        private Label lblY;
        private TextBox txtZ;
        private Label lblZ;
        private Button btnVerificar;
    }
}