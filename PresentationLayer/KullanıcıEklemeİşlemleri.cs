using DAL.Context;
using DAL.Entities.Concrate;
using BusinessLayer.Services;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Kullan�c�Ekleme��lemleri : Form
    {
        public Kullan�c�Ekleme��lemleri()
        {
            InitializeComponent();
        }
        KullaniciManager _kullaniciManager = new KullaniciManager(new DAL.Repositories.KullaniciRepository(new PlakD�kkan�DBContext()));

        private void btnEkle_Click(object sender, EventArgs e)
        {

            _kullaniciManager.Create(new Kullanici
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text
            });

            MessageBox.Show("Kullan�c� Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
