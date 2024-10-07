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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //byte notOrtalamasi = 80;

            //if (notOrtalamasi >= 45)
            //{
            //    MessageBox.Show("Sınıfını geçti");
            //}

            //else
            //{
            //    MessageBox.Show("Kaldınız.");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //byte devamsizlikSayisi = 15;
            //byte notOrtalamasi = 85;

            //if (devamsizlikSayisi < 10 & notOrtalamasi >= 70)
            //{
            //    MessageBox.Show("Sınıfı geçti.");
            //}

            //else
            //{
            //    MessageBox.Show("Kaldı");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //byte pNOrt = 66;
            //byte gNOrt = 75;

            //if (pNOrt > 65 | gNOrt >= 90)
            //{
            //    //sınıfı geçti
            //}

            //else
            //{
            //    //kaldı
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             500 ile 1000 tl arasında alışveriş yapan müşterilere %20
             1000 ile 2500 tl arasında alışveriş yapan müşterilere %25
             2500 ile 5000 tl arasında alışveriş yapan müşterilere %35
             5000 tl den fazla alışveriş yapan müşterilere %45
             */

            bool indirimVarMi = true;
            double musteriSatisTutari = Convert.ToDouble(txt_müsteritutari.Text);

            if (musteriSatisTutari >= 500 & musteriSatisTutari <= 1000)
            {
                //%20
                // double yeniTutar = musteriSatisTutari - (musteriSatisTutari * 0.20);

               // musteriSatisTutari = musteriSatisTutari - (musteriSatisTutari * 0.20);

                musteriSatisTutari -= musteriSatisTutari * 0.20;
            }

            else if (musteriSatisTutari > 1000 & musteriSatisTutari <= 2500)
            {
                // %25
                musteriSatisTutari -= musteriSatisTutari * 0.25;

            }

            else if (musteriSatisTutari > 2500 & musteriSatisTutari <= 5000)
            {
                //%35
                musteriSatisTutari -= musteriSatisTutari * 0.35;

            }

            else if (musteriSatisTutari > 5000 )
            {
                //%45
                musteriSatisTutari -= musteriSatisTutari * 0.45;

            }

            else
            {
                //indirim yok
                
                lbl_sondurum.Text = "İndirim hakkınız bulunmamaktadır.";

            }

        }
    }
}
