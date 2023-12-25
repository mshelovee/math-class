namespace math_sınıfı
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblUst = new System.Windows.Forms.Label();
            this.lblKok = new System.Windows.Forms.Label();
            this.lblYuvarlama = new System.Windows.Forms.Label();
            this.lblAsagi = new System.Windows.Forms.Label();
            this.lblYukari = new System.Windows.Forms.Label();
            this.lblMutlak = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(64, 104);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(104, 45);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblUst
            // 
            this.lblUst.AutoSize = true;
            this.lblUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUst.Location = new System.Drawing.Point(212, 65);
            this.lblUst.Name = "lblUst";
            this.lblUst.Size = new System.Drawing.Size(61, 16);
            this.lblUst.TabIndex = 1;
            this.lblUst.Text = "Üst Alma";
            // 
            // lblKok
            // 
            this.lblKok.AutoSize = true;
            this.lblKok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKok.Location = new System.Drawing.Point(212, 85);
            this.lblKok.Name = "lblKok";
            this.lblKok.Size = new System.Drawing.Size(91, 16);
            this.lblKok.TabIndex = 2;
            this.lblKok.Text = "Karekök Alma";
            // 
            // lblYuvarlama
            // 
            this.lblYuvarlama.AutoSize = true;
            this.lblYuvarlama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuvarlama.Location = new System.Drawing.Point(212, 109);
            this.lblYuvarlama.Name = "lblYuvarlama";
            this.lblYuvarlama.Size = new System.Drawing.Size(72, 16);
            this.lblYuvarlama.TabIndex = 3;
            this.lblYuvarlama.Text = "Yuvarlama";
            // 
            // lblAsagi
            // 
            this.lblAsagi.AutoSize = true;
            this.lblAsagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAsagi.Location = new System.Drawing.Point(212, 133);
            this.lblAsagi.Name = "lblAsagi";
            this.lblAsagi.Size = new System.Drawing.Size(110, 16);
            this.lblAsagi.TabIndex = 4;
            this.lblAsagi.Text = "Aşağı Yuvarlama";
            // 
            // lblYukari
            // 
            this.lblYukari.AutoSize = true;
            this.lblYukari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukari.Location = new System.Drawing.Point(212, 157);
            this.lblYukari.Name = "lblYukari";
            this.lblYukari.Size = new System.Drawing.Size(113, 16);
            this.lblYukari.TabIndex = 5;
            this.lblYukari.Text = "Yukarı Yuvarlama";
            // 
            // lblMutlak
            // 
            this.lblMutlak.AutoSize = true;
            this.lblMutlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMutlak.Location = new System.Drawing.Point(212, 184);
            this.lblMutlak.Name = "lblMutlak";
            this.lblMutlak.Size = new System.Drawing.Size(87, 16);
            this.lblMutlak.TabIndex = 6;
            this.lblMutlak.Text = "Mutlak Değer";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(64, 68);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(104, 20);
            this.txtSayi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 258);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lblMutlak);
            this.Controls.Add(this.lblYukari);
            this.Controls.Add(this.lblAsagi);
            this.Controls.Add(this.lblYuvarlama);
            this.Controls.Add(this.lblKok);
            this.Controls.Add(this.lblUst);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblUst;
        private System.Windows.Forms.Label lblKok;
        private System.Windows.Forms.Label lblYuvarlama;
        private System.Windows.Forms.Label lblAsagi;
        private System.Windows.Forms.Label lblYukari;
        private System.Windows.Forms.Label lblMutlak;
        private System.Windows.Forms.TextBox txtSayi;
    }
}

