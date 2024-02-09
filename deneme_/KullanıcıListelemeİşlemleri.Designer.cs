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
            btnSil = new Button();
            BtnGuncelle = new Button();
            btnİptal = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(110, 67);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(110, 93);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(241, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(458, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(607, 185);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(92, 57);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(12, 139);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(92, 39);
            BtnGuncelle.TabIndex = 4;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // btnİptal
            // 
            btnİptal.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnİptal.Location = new Point(110, 139);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(75, 39);
            btnİptal.TabIndex = 5;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 67);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 7;
            label2.Text = "Şifre";
            // 
            // KullanıcıListelemeİşlemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 254);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnİptal);
            Controls.Add(BtnGuncelle);
            Controls.Add(btnSil);
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
        private Button btnSil;
        private Button BtnGuncelle;
        private Button btnİptal;
        private Label label1;
        private Label label2;
    }
}