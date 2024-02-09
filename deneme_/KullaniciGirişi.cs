using BusinessLayer.Services;
using DAL.Context;
using DAL.Entities.Concrate;
using System.Windows.Forms;

namespace deneme_
{
    public partial class KullaniciGiriþi : Form
    {
        //public KullaniciGiriþi(PlakDükkanýDBContext DBContext)
        //{
        //    InitializeComponent();
        //    this.dBContext = dBContext;
        //}
        KullaniciManager _kullaniciManager = new KullaniciManager(new DAL.Repositories.KullaniciRepository(new PlakDükkanýDBContext()));
        //PlakDükkanýDBContext dBContext = new PlakDükkanýDBContext();
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
            MessageBox.Show("Kullanýcý Eklendi.");
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