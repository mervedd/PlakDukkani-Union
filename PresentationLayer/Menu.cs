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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            KullanıcıEklemeİşlemleri kullanıcıEkleme = new KullanıcıEklemeİşlemleri();
            kullanıcıEkleme.ShowDialog();
        }

        private void btnKullaniciListele_Click(object sender, EventArgs e)
        {
            KullanıcıListelemeİşlemleri kullanıcıListeleme = new KullanıcıListelemeİşlemleri();
            kullanıcıListeleme.ShowDialog();
        }

        private void btnAlbumEkle_Click(object sender, EventArgs e)
        {
            AlbumEklemeİşlemleri albumEkleme = new AlbumEklemeİşlemleri();
            albumEkleme.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


    }
}
