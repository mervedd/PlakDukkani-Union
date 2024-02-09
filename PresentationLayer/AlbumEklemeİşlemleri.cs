using BusinessLayer.Services;
using DAL.Context;
using DAL.Entities.Concrate;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PresentationLayer
{
    public partial class AlbumEklemeİşlemleri : Form
    {
        public AlbumEklemeİşlemleri()
        {
            InitializeComponent();
        }
        Album seciliAlbum = new Album();
        AlbumManager _albumManager = new AlbumManager(new DAL.Repositories.AlbumRepository(new PlakDükkanıDBContext()));

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Album yeniAlbum = new Album();
            if (txtKullaniciAdi.Text != " ")
            {

                yeniAlbum.AlbumAdi = txtKullaniciAdi.Text;

            }
            else
            {
                MessageBox.Show("Ad boş bırakılamaz");
            }

            if (txtSanatci.Text != " ")
            {
                yeniAlbum.Sanatci = txtSanatci.Text;

            }
            else
            {
                MessageBox.Show("Sanatçı boş bırakılamaz");
            }
            yeniAlbum.CikisTarihi = dateTimePicker1.Value;
            yeniAlbum.CreatedDate = dateTimePicker1.Value;
            yeniAlbum.ModifiedDate = dateTimePicker1.Value;


            if (txtFiyat.Text != " ")
            {
                yeniAlbum.Fiyat = Convert.ToDecimal(txtFiyat.Text);
            }
            else
            {
                MessageBox.Show("Fiyat boş bırakılamaz");
            }
            if (txtİndirim.Text != " ")
            {
                yeniAlbum.IndirimOrani = Convert.ToDecimal(txtİndirim.Text);
            }
            else
            {
                MessageBox.Show("İndirim oranı boş bırakılamaz");
            }
            if (rbBitti.Checked)
            {
                yeniAlbum.SatisDurumu = false;
            }

            else
            {
                yeniAlbum.SatisDurumu = true;
            }
            _albumManager.create(yeniAlbum);
            ListeyiGuncelle();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            seciliAlbum = _albumManager.GetById(x => x.Id == seciliID);
            txtKullaniciAdi.Text = seciliAlbum.AlbumAdi;
            txtSanatci.Text = seciliAlbum.Sanatci;
            txtFiyat.Text = Convert.ToString(seciliAlbum.Fiyat);
            txtİndirim.Text = Convert.ToString(seciliAlbum.IndirimOrani);

            if (seciliAlbum.SatisDurumu == true)
            {
                rbDevam.Checked = true;
            }
            else
            {
                rbBitti.Checked = true;
            }
        }
        public void ListeyiGuncelle()
        {
            dataGridView1.DataSource = _albumManager.GetAll();
        }
        private void AlbumEklemeİşlemleri_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int seciliID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            seciliAlbum = _albumManager.GetById(x => x.Id == seciliID);
            seciliAlbum.AlbumAdi = txtKullaniciAdi.Text;
            seciliAlbum.CikisTarihi = dateTimePicker1.Value;
            seciliAlbum.ModifiedDate = dateTimePicker1.Value;
            seciliAlbum.CreatedDate = dateTimePicker1.Value;
            seciliAlbum.Sanatci = txtSanatci.Text;
            seciliAlbum.Fiyat = Convert.ToDecimal(txtFiyat.Text);
            seciliAlbum.IndirimOrani = Convert.ToDecimal(txtİndirim.Text);
            _albumManager.Update(seciliAlbum.Id);

            if (rbBitti.Checked)
            {
                seciliAlbum.SatisDurumu = false;
            }

            else
            {
                seciliAlbum.SatisDurumu = true;
            }

            ListeyiGuncelle();
            Temizle();
        }


        public void Temizle()
        {
            txtKullaniciAdi.Text = "";
            txtSanatci.Text = "";
            txtİndirim.Text = "";
            txtFiyat.Text = "";
            rbDevam.Checked = false;
            rbBitti.Checked = false;
            dateTimePicker1.Value = DateTime.Now;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //if (seciliAlbum.Id != null && seciliAlbum.Id > 0)
            //{
            var value = _albumManager.GetById(x => x.Id == seciliAlbum.Id);
            if (value != null)
            {

                _albumManager.Delete(seciliAlbum.Id);

            }


            else
            {
                MessageBox.Show("Bir Album Seçin");
            }
            ListeyiGuncelle();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //seciliAlbum = _albumManager.GetById(x => x.AlbumAdi == txtSanatci.Text.ToString());

            //if (seciliAlbum != null)
            //{

            //    txtAlbumAdi.Text = seciliAlbum.AlbumAdi.ToString();

            //    seciliAlbum.Id = seciliAlbum.Id;
            //    _albumManager.Update(seciliAlbum.Id);
            //}
        }
    }
}
