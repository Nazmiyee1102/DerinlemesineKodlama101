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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MesajVer();
        }

        void MesajVer()
        {
            MessageBox.Show("İşlem başarılı.");
        }

        void SendMessage(string message)
        {
            MessageBox.Show(message);
        }

        void SendMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        void SendMessage(string message, string title, MessageBoxButtons buton)
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        void Sum(int a, int b)
        {
            int toplam = a + b;
            MessageBox.Show(toplam.ToString());
        }

        int SayilariTopla(int a, int b)
        {
            int sonuc = a + b;
            return sonuc;

            //return a + b;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SendMessage("Hoş geldin");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendMessage("Merhaba", "Kayıt tamamlandı.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendMessage("Mevcut ürünü silmek istediğinize emin misiniz?",
                "Silme İşlemi", MessageBoxButtons.YesNo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sum(1, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int toplamSonucu = SayilariTopla(56, 789);
            MessageBox.Show(toplamSonucu.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] diziler = { 1, 2, 3, 4, 5, 6, 7, 8 };

            int sonuc = ToplamaYap(diziler);

            // int sonuc = ToplamaYap(34,21,"Nazmiye");
        }

        private int ToplamaYap(int[] diziler)
        {
            int toplam = 0;
            foreach (var item in diziler)
            {
                toplam += item;
            }

            return toplam;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
