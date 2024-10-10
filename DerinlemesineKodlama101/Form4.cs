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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            /*
             Döngüler
             */




        }

        string[] kategoriler = {"Elektronik", "Bahçe Malzemeleri",
            "Teknoloji", "Laptop"};


        private void btn_for_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < 5; i++)
            {
                lst_Liste.Items.Add("Nazmiye");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    lst_Liste.Items.Add(i);
            //}

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    lst_Liste.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < kategoriler.Length; i++)
            {
                lst_Liste.Items.Add($"{i + 1}. {kategoriler[i]}");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            while (sayac <= 50)
            {
                lst_Liste.Items.Add(sayac + 1);
                sayac++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int counter = 1;
            do
            {
                lst_Liste.Items.Add(counter);
                counter++;
            }
            while (counter <= 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int sayac = 1;
            foreach (var item in kategoriler)
            {
                lst_Liste.Items.Add($"{sayac++}. {item}");
            }
        }
    }
}
