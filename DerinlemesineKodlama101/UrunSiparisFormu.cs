using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerinlemesineKodlama101
{
    public partial class UrunSiparisFormu : Form
    {
        public UrunSiparisFormu()
        {
            InitializeComponent();
        }

        string[,] urunListesi = new string[3, 2];


        private void UrunSiparisFormu_Load(object sender, EventArgs e)
        {

            UrunleriHazirla();

            //   ComboboxaKategorileriGetirGetNames();

            ComboboxaKategorileriGetirGetValues();
        }

        private void ComboboxaKategorileriGetirGetValues()
        {
            Array dizi = Enum.GetValues(typeof(Kategoriler));

            foreach (var item in dizi)
            {
                cmbKategoriler.Items.Add(item);
            }
        }

        private void UrunleriHazirla()
        {
            urunListesi[0, 0] = "0";
            urunListesi[0, 1] = "VGA";
            urunListesi[1, 0] = "1";
            urunListesi[1, 1] = "RAM";
            urunListesi[2, 0] = "2";
            urunListesi[2, 1] = "KOLTUK";
        }

        byte secilen;

        private void ComboboxaKategorileriGetirGetNames()
        {
            string[] kategoriler = Enum.GetNames(typeof(Kategoriler));

            foreach (var item in kategoriler)
            {
                cmbKategoriler.Items.Add(item);
            }
        }


        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = (byte)cmbKategoriler.SelectedItem;

            UrunleriListeyeDoldur(secilen);
        }

        private void UrunleriListeyeDoldur(byte secilenKategori)
        {
            lstListe.Items.Clear();
            int satirSayisi = urunListesi.GetLength(0);
            int sutunSayisi = urunListesi.GetLength(1);

            for (int i = 0; i < satirSayisi; i++)
            {
                if (urunListesi[i, 0] == secilen.ToString())
                {
                    lstListe.Items.Add(urunListesi[i, 1]);
                }
            }
        }

        decimal sonuc;

        private void txtBirimFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstListe.SelectedIndex != -1 & nmrAdet.Value != 0 &
                !string.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    sonuc = nmrAdet.Value * Convert.ToDecimal(txtBirimFiyat.Text);
                    txtToplamTutar.Text = sonuc.ToString();
                }
            }
        }

        double kdvliFiyat = 0;
        int sayac = 0;
        double[] kdvliFiyatlar = new double[1];


        private void button1_Click(object sender, EventArgs e)
        {

            bool hangiFaturaTipi = rdKurumsal.Checked ? true : false;

            if (hangiFaturaTipi)
            {
                //kurumsal
                kdvliFiyat = Convert.ToDouble(sonuc) * 1.20d;
            }
            else
            { 
                //bireysel
                kdvliFiyat = Convert.ToDouble(sonuc) * 1.18;
            }

            kdvliFiyatlar[sayac] = kdvliFiyat;
            sayac++;
            Array.Resize(ref kdvliFiyatlar, kdvliFiyatlar.Length + 1);

            string sepeteEklenecek = $"{lstListe.SelectedItem.ToString()} - {nmrAdet.Value.ToString()} * {txtBirimFiyat.Text} = {kdvliFiyat}";

            lstSepet.Items.Add(sepeteEklenecek);

            lblSepetToplami.Text = ToplamGuncelle().ToString();
        }

        private double ToplamGuncelle()
        {
            double toplam = 0;

            foreach (var item in kdvliFiyatlar)
            {
                toplam += item;
                    
            }

            return toplam;
        }
    }
}
