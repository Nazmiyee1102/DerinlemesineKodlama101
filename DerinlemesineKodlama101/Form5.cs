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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            string metin = txt_cumle.Text;
            char aranan = Convert.ToChar(txt_aranan.Text);
            char[] dizi = metin.ToCharArray();

            //string egitim = "Yazılım";
            //char karakter = egitim[0];

            for (int i = 0; i < metin.Length; i++)
            {
                if (dizi[i] == aranan)
                {
                    dizi[i] = 'X';
                }
            }

            txt_cumle.Text = new string(dizi);

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string metin = txt_cumle.Text;
            char aranan = Convert.ToChar(txt_aranan.Text);
            char[] dizi = metin.ToCharArray();

            int sayac = 0;
            foreach (var item in metin)
            {
                if (item == aranan)
                {
                    sayac++;
                }
            }

            lbl_sonuc.Text = sayac.ToString();

        }

        private void btn_dizi_Click(object sender, EventArgs e)
        {
            string[] categories = { "SSD", "RAM", "CPU", 
                "BOARD", "VGA" };

            //dizide inde bulma
           int index =  Array.IndexOf(categories, "RAM");

            if (index != -1)
            {
                categories[index] = "ROM";
            }
            else
            {
                MessageBox.Show("Aranan değer bulunamadı.");
            }

            foreach (var item in categories)
            {
                lst_Liste.Items.Add(item);
            }
        }
    }
}
