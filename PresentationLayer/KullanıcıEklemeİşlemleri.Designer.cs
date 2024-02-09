namespace PresentationLayer
{
    partial class KullanıcıEklemeİşlemleri
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
            btnEkle = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            btnSil = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(45, 104);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 41);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(100, 63);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(136, 23);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(100, 34);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(136, 23);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(126, 104);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 41);
            btnSil.TabIndex = 3;
            btnSil.Text = "İptal";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 62);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Şifre";
            // 
            // KullanıcıEklemeİşlemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 183);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(btnEkle);
            Name = "KullanıcıEklemeİşlemleri";
            Text = "KullaniciEklemeİşlemleri";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Button btnSil;
        private Label label1;
        private Label label2;
    }
}