namespace PresentationLayer
{
    partial class KullanıcıListelemeİşlemleri
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            dataGridView1 = new DataGridView();
            btnGuncelle = new Button();
            btnİptal = new Button();
            btnSil = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(91, 30);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(91, 64);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(472, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(20, 93);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 40);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(101, 93);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(75, 40);
            btnİptal.TabIndex = 4;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(594, 204);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 43);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 7;
            label2.Text = "Şifre";
            // 
            // KullanıcıListelemeİşlemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 270);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnİptal);
            Controls.Add(btnGuncelle);
            Controls.Add(dataGridView1);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "KullanıcıListelemeİşlemleri";
            Text = "KullanıcıListelemeİşlemleri";
            Load += KullanıcıListelemeİşlemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private DataGridView dataGridView1;
        private Button btnGuncelle;
        private Button btnİptal;
        private Button btnSil;
        private Label label1;
        private Label label2;
    }
}