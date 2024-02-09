namespace PresentationLayer
{
    partial class AlbumEklemeİşlemleri
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
            txtSanatci = new TextBox();
            txtFiyat = new TextBox();
            txtİndirim = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            txtKullaniciAdi = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            rbBitti = new RadioButton();
            rbDevam = new RadioButton();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSil = new Button();
            label5 = new Label();
            btnİptal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(105, 59);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(100, 23);
            txtSanatci.TabIndex = 0;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(105, 88);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(100, 23);
            txtFiyat.TabIndex = 1;
            // 
            // txtİndirim
            // 
            txtİndirim.Location = new Point(105, 117);
            txtİndirim.Name = "txtİndirim";
            txtİndirim.Size = new Size(100, 23);
            txtİndirim.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(49, 200);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 52);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(130, 200);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 52);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(105, 30);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(105, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // rbBitti
            // 
            rbBitti.AutoSize = true;
            rbBitti.Location = new Point(78, 175);
            rbBitti.Name = "rbBitti";
            rbBitti.Size = new Size(46, 19);
            rbBitti.TabIndex = 7;
            rbBitti.TabStop = true;
            rbBitti.Text = "Bitti";
            rbBitti.UseVisualStyleBackColor = true;
            // 
            // rbDevam
            // 
            rbDevam.AutoSize = true;
            rbDevam.Location = new Point(143, 175);
            rbDevam.Name = "rbDevam";
            rbDevam.Size = new Size(62, 19);
            rbDevam.TabIndex = 8;
            rbDevam.TabStop = true;
            rbDevam.Text = "Devam";
            rbDevam.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(302, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(549, 150);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 12;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 59);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 13;
            label2.Text = "Sanatçı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 88);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 14;
            label3.Text = "Fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 117);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 15;
            label4.Text = "İndirim";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(695, 198);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 43);
            btnSil.TabIndex = 16;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 146);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 17;
            label5.Text = "Tarih";
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(776, 198);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(75, 43);
            btnİptal.TabIndex = 18;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // AlbumEklemeİşlemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 278);
            Controls.Add(btnİptal);
            Controls.Add(label5);
            Controls.Add(btnSil);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(rbDevam);
            Controls.Add(rbBitti);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtİndirim);
            Controls.Add(txtFiyat);
            Controls.Add(txtSanatci);
            Name = "AlbumEklemeİşlemleri";
            Text = "AlbumEkleme";
            Load += AlbumEklemeİşlemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSanatci;
        private TextBox txtFiyat;
        private TextBox txtİndirim;
        private Button btnEkle;
        private Button btnGuncelle;
        private TextBox txtKullaniciAdi;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbBitti;
        private RadioButton rbDevam;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSil;
        private Label label5;
        private Button btnİptal;
    }
}