namespace LibraryProjectWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.lblPersonelAdi = new System.Windows.Forms.Label();
            this.lblPersonelSifre = new System.Windows.Forms.Label();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(161, 279);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(131, 20);
            this.txtPersonelAdi.TabIndex = 0;
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(161, 317);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.PasswordChar = '*';
            this.txtPersonelSifre.Size = new System.Drawing.Size(131, 20);
            this.txtPersonelSifre.TabIndex = 1;
            // 
            // lblPersonelAdi
            // 
            this.lblPersonelAdi.AutoSize = true;
            this.lblPersonelAdi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPersonelAdi.Location = new System.Drawing.Point(76, 282);
            this.lblPersonelAdi.Name = "lblPersonelAdi";
            this.lblPersonelAdi.Size = new System.Drawing.Size(69, 13);
            this.lblPersonelAdi.TabIndex = 2;
            this.lblPersonelAdi.Text = "Personel Adı:";
            // 
            // lblPersonelSifre
            // 
            this.lblPersonelSifre.AutoSize = true;
            this.lblPersonelSifre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPersonelSifre.Location = new System.Drawing.Point(107, 320);
            this.lblPersonelSifre.Name = "lblPersonelSifre";
            this.lblPersonelSifre.Size = new System.Drawing.Size(31, 13);
            this.lblPersonelSifre.TabIndex = 3;
            this.lblPersonelSifre.Text = "Sifre:";
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPersonelGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPersonelGiris.Location = new System.Drawing.Point(184, 354);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(84, 27);
            this.btnPersonelGiris.TabIndex = 4;
            this.btnPersonelGiris.Text = "Giris";
            this.btnPersonelGiris.UseVisualStyleBackColor = false;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(158, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Made By Mehmet Ertuğrul";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(423, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.lblPersonelSifre);
            this.Controls.Add(this.lblPersonelAdi);
            this.Controls.Add(this.txtPersonelSifre);
            this.Controls.Add(this.txtPersonelAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.Label lblPersonelAdi;
        private System.Windows.Forms.Label lblPersonelSifre;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

