using BusinessLayer.Services;
using DAL.Context;
using DAL.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class KullanıcıListelemeİşlemleri : Form
    {
        public KullanıcıListelemeİşlemleri()
        {
            InitializeComponent();
        }
        Kullanici seciliKullanici = new Kullanici();
        KullaniciManager _kullaniciManager = new KullaniciManager(new DAL.Repositories.KullaniciRepository(new PlakDükkanıDBContext()));

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKullanici.Id != null && seciliKullanici.Id > 0)
            {
                seciliKullanici.KullaniciAdi = txtKullaniciAdi.Text;

                _kullaniciManager.Update(seciliKullanici.Id);
                ListeGuncelle();
            }
            else
            {
                MessageBox.Show("Bir kullanıcı seçin");
            }

            if (seciliKullanici.Id != null && seciliKullanici.Id > 0)
            {
                seciliKullanici.Sifre = txtSifre.Text;

                _kullaniciManager.Update(seciliKullanici.Id);
                ListeGuncelle();
            }
            else
            {
                MessageBox.Show("Bir kullanıcı seçin");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            seciliKullanici = _kullaniciManager.GetById(x => x.Id == seciliID);
            txtKullaniciAdi.Text = seciliKullanici.KullaniciAdi.ToString();
            txtSifre.Text = seciliKullanici.Sifre.ToString();
        }

        public void ListeGuncelle()
        {
            dataGridView1.DataSource = _kullaniciManager.GetAll();
        }

        private void KullanıcıListelemeİşlemleri_Load(object sender, EventArgs e)
        {
            ListeGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKullanici.Id != null && seciliKullanici.Id > 0)
            {
                _kullaniciManager.Delete(seciliKullanici.Id);
            }
            else
            {
                MessageBox.Show("Bir kullanıcı seçin");
            }

            ListeGuncelle();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
