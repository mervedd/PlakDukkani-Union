namespace PresentationLayer
{
    partial class Menu
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
            btnKullaniciEkle = new Button();
            btnKullaniciListele = new Button();
            btnAlbumEkle = new Button();
            SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.Location = new Point(172, 58);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(145, 62);
            btnKullaniciEkle.TabIndex = 0;
            btnKullaniciEkle.Text = "Kullanıcı Ekle";
            btnKullaniciEkle.UseVisualStyleBackColor = true;
            btnKullaniciEkle.Click += btnKullaniciEkle_Click;
            // 
            // btnKullaniciListele
            // 
            btnKullaniciListele.Location = new Point(19, 58);
            btnKullaniciListele.Name = "btnKullaniciListele";
            btnKullaniciListele.Size = new Size(145, 62);
            btnKullaniciListele.TabIndex = 1;
            btnKullaniciListele.Text = "Kullanıcı Listele";
            btnKullaniciListele.UseVisualStyleBackColor = true;
            btnKullaniciListele.Click += btnKullaniciListele_Click;
            // 
            // btnAlbumEkle
            // 
            btnAlbumEkle.Location = new Point(323, 58);
            btnAlbumEkle.Name = "btnAlbumEkle";
            btnAlbumEkle.Size = new Size(145, 60);
            btnAlbumEkle.TabIndex = 2;
            btnAlbumEkle.Text = "Album İşlemleri";
            btnAlbumEkle.UseVisualStyleBackColor = true;
            btnAlbumEkle.Click += btnAlbumEkle_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 182);
            Controls.Add(btnAlbumEkle);
            Controls.Add(btnKullaniciListele);
            Controls.Add(btnKullaniciEkle);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnKullaniciEkle;
        private Button btnKullaniciListele;
        private Button btnAlbumEkle;
    }
}