namespace deneme_
{
    partial class KullaniciGirişi
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
            txtID = new TextBox();
            txtAd = new TextBox();
            txtSifre = new TextBox();
            btnEkle = new Button();
            btnİptal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(216, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(137, 23);
            txtID.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(216, 69);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(137, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(216, 98);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(137, 23);
            txtSifre.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(162, 142);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 44);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnİptal
            // 
            btnİptal.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnİptal.Location = new Point(257, 142);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(75, 44);
            btnİptal.TabIndex = 5;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 40);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(136, 69);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 7;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(136, 99);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // KullaniciGirişi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 205);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnİptal);
            Controls.Add(btnEkle);
            Controls.Add(txtSifre);
            Controls.Add(txtAd);
            Controls.Add(txtID);
            Name = "KullaniciGirişi";
            Text = "Kullanıcı Girişi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtAd;
        private TextBox txtSifre;
        private Button btnEkle;
        private Button btnİptal;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}