using BusinessLayer.Services;
using DAL.Context;
using DAL.Entities.Concrate;
using System.Windows.Forms;

namespace deneme_
{
    public partial class KullaniciGiri�i : Form
    {
        //public KullaniciGiri�i(PlakD�kkan�DBContext DBContext)
        //{
        //    InitializeComponent();
        //    this.dBContext = dBContext;
        //}
        KullaniciManager _kullaniciManager = new KullaniciManager(new DAL.Repositories.KullaniciRepository(new PlakD�kkan�DBContext()));
        //PlakD�kkan�DBContext dBContext = new PlakD�kkan�DBContext();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _kullaniciManager.Create(new Kullanici
            {
                KullaniciAdi = txtAd.Text,
                Sifre = txtSifre.Text,

            });
            MessageBox.Show("Kullan�c� Eklendi.");
            //dBContext.Kullanicilar.Add(new Kullanici
            //{
            //    KullaniciAdi = txtAd.Text,
            //    Sifre = txtSifre.Text,


            //});
            //dBContext.SaveChangesAsync();
            //var silinecek = dBContext.Kullanicilar.Find(2);

            //dBContext.Kullanicilar.Remove(silinecek);
            //dBContext.SaveChangesAsync();
            //var guncellenecek = dBContext.Kullanicilar.Find(2);
            //guncellenecek.KullaniciAdi = "Test";
            //dBContext.SaveChangesAsync();

            //var values = dBContext.Kullanicilar.ToList();

        }
    }
}