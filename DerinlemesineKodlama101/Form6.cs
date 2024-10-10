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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int[] secilenSayilar = new int[6];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i <= 5; i++)
            {
                Random random = new Random();
                int gelenSayi = random.Next(6, 49);
                listBox1.Items.Add(gelenSayi);

            }
        }

        private void btn_uret_Click_(object sender, EventArgs e)
        {
            int randomSayi;

            listBox1.Items.Clear();

            for (int i = 0; i < secilenSayilar.Length; i++)
            {
                do
                {
                    Random random = new Random();
                     randomSayi = random.Next(6, 50);
                }
                while (secilenSayilar.Contains(randomSayi));

                secilenSayilar[i] = randomSayi;
            }

            foreach (var item in secilenSayilar)
            {
                listBox1.Items.Add(item);  
            }
        }
    }
}
