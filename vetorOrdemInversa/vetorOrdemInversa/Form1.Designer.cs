namespace vetorOrdemInversa
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
            this.btnValores = new System.Windows.Forms.Button();
            this.lstB = new System.Windows.Forms.ListBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnValores
            // 
            this.btnValores.Location = new System.Drawing.Point(139, 47);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(286, 50);
            this.btnValores.TabIndex = 0;
            this.btnValores.Text = "Digitar valores";
            this.btnValores.UseVisualStyleBackColor = true;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 20;
            this.lstB.Location = new System.Drawing.Point(286, 118);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(139, 184);
            this.lstB.TabIndex = 1;
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 20;
            this.lstA.Location = new System.Drawing.Point(141, 116);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(133, 184);
            this.lstA.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 314);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.lstB);
            this.Controls.Add(this.btnValores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValores;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.ListBox lstA;
    }
}

