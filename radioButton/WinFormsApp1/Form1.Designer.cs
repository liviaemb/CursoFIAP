namespace WinFormsApp1
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
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculisno = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.rbtJava = new System.Windows.Forms.RadioButton();
            this.rbtNet = new System.Windows.Forms.RadioButton();
            this.rbtC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(12, 42);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(110, 29);
            this.rbtFeminino.TabIndex = 0;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculisno
            // 
            this.rbtMasculisno.AutoSize = true;
            this.rbtMasculisno.Location = new System.Drawing.Point(12, 91);
            this.rbtMasculisno.Name = "rbtMasculisno";
            this.rbtMasculisno.Size = new System.Drawing.Size(117, 29);
            this.rbtMasculisno.TabIndex = 1;
            this.rbtMasculisno.TabStop = true;
            this.rbtMasculisno.Text = "Masculino";
            this.rbtMasculisno.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(112, 261);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 34);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // rbtJava
            // 
            this.rbtJava.AutoSize = true;
            this.rbtJava.Location = new System.Drawing.Point(11, 46);
            this.rbtJava.Name = "rbtJava";
            this.rbtJava.Size = new System.Drawing.Size(115, 29);
            this.rbtJava.TabIndex = 3;
            this.rbtJava.TabStop = true;
            this.rbtJava.Text = "JavaScript";
            this.rbtJava.UseVisualStyleBackColor = true;
            // 
            // rbtNet
            // 
            this.rbtNet.AutoSize = true;
            this.rbtNet.Location = new System.Drawing.Point(11, 81);
            this.rbtNet.Name = "rbtNet";
            this.rbtNet.Size = new System.Drawing.Size(72, 29);
            this.rbtNet.TabIndex = 4;
            this.rbtNet.TabStop = true;
            this.rbtNet.Text = ".NET";
            this.rbtNet.UseVisualStyleBackColor = true;
            // 
            // rbtC
            // 
            this.rbtC.AutoSize = true;
            this.rbtC.Location = new System.Drawing.Point(11, 116);
            this.rbtC.Name = "rbtC";
            this.rbtC.Size = new System.Drawing.Size(59, 29);
            this.rbtC.TabIndex = 5;
            this.rbtC.TabStop = true;
            this.rbtC.Text = "C#";
            this.rbtC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtMasculisno);
            this.groupBox1.Controls.Add(this.rbtFeminino);
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo ↓";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtC);
            this.groupBox2.Controls.Add(this.rbtNet);
            this.groupBox2.Controls.Add(this.rbtJava);
            this.groupBox2.Location = new System.Drawing.Point(154, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 162);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Curso desejado ↓";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 324);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton rbtFeminino;
        private RadioButton rbtMasculisno;
        private Button btnConfirmar;
        private RadioButton rbtJava;
        private RadioButton rbtNet;
        private RadioButton rbtC;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}