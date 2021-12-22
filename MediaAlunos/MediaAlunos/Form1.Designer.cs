namespace MediaAlunos
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
            this.lblN1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.lblN3 = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(100, 21);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(44, 25);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "AV1";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(49, 49);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(163, 31);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(49, 117);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(163, 31);
            this.txtN2.TabIndex = 3;
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(100, 89);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(44, 25);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "AV2";
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(49, 196);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(163, 31);
            this.txtN3.TabIndex = 5;
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(100, 168);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(44, 25);
            this.lblN3.TabIndex = 4;
            this.lblN3.Text = "AV3";
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(66, 247);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(112, 34);
            this.btnMedia.TabIndex = 6;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 419);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblN1);
            this.Name = "Form1";
            this.Text = "Media alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblN1;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label lblN2;
        private TextBox txtN3;
        private Label lblN3;
        private Button btnMedia;
    }
}