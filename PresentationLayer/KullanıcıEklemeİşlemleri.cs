using DAL.Context;
using DAL.Entities.Concrate;
using BusinessLayer.Services;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class KullanýcýEklemeÝþlemleri : Form
    {
        public KullanýcýEklemeÝþlemleri()
        {
            InitializeComponent();
        }
        KullaniciManager _kullaniciManager = new KullaniciManager(new DAL.Repositories.KullaniciRepository(new PlakDükkanýDBContext()));

        private void btnEkle_Click(object sender, EventArgs e)
        {

            _kullaniciManager.Create(new Kullanici
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text
            });

            MessageBox.Show("Kullanýcý Eklendi");
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
