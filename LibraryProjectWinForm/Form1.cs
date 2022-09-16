using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectWinForm
{
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db= new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            string gelenAd = txtPersonelAdi.Text;
            string gelenSifre = txtPersonelSifre.Text;

            var personel = db.Personeller.Where(p => p.personel_ad.Equals(gelenAd) && p.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if (personel!=null)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }

        }
    }
}
