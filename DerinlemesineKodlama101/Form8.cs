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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                string adSoyad = txtAdSoyad.Text;
                double vizeNotu = double.Parse(txtVize.Text);
                double finalNotu = double.Parse(txtFinal.Text); 

                double ortalama = OrtalamaHesapla(vizeNotu, finalNotu);
                ogrenciListesi[adSoyad] = ortalama;

                ListeyiGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListeyiGuncelle()
        {
            listBox1.Items.Clear();

            foreach (var item in ogrenciListesi)
            {
                listBox1.Items.Add($"{item.Key} - {item.Value}");
            }
        }

        Dictionary<string, double> ogrenciListesi = new 
            Dictionary<string, double>();
     //   listBox1.Items.Add($"{adSoyad} - {ortalama}");


        private double OrtalamaHesapla(double vizeNotu, double finalNotu)
        {
            double ort = (vizeNotu * 0.40) + (finalNotu * 0.60);

            return ort;
        }
    }
}
