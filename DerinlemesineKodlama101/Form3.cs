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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] ogrenciListesi = { "Nazmiye", "KURBAN", "23" };

            MessageBox.Show(ogrenciListesi[1]);
        }

        string[] studentList = new string[3];
        int sayac = 0;

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string nameSurname = txt_ogrenciadi.Text;

            studentList[sayac] = nameSurname;
            sayac++;

            int elemanSayisi = studentList.Length;

            Array.Resize(ref studentList, elemanSayisi + 1);
        }
    }
}
