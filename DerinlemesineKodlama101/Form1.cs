namespace DerinlemesineKodlama101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region �lk Ders               

            //variables 
            //string name = "Nazmiye";
            //string nameSurname = "Nazmiye KURBAN";

            //int number1 = 25;
            //double number2 = 4.5;
            //decimal number3 = 6.4m;
            //float number4 = 84.13f;

            //bool answer = false;
            //bool result = true;

            //string adSoyad = txt_AdSoyad.Text;

            //byte not = Convert.ToByte("45");
            //byte dersNotu = Convert.ToByte(txt_DersNotu);
            //double notHesaplama = dersNotu * 0.40;



            //MessageBox.Show(notHesaplama.ToString());

            //string ifade = adSoyad + " " + "adl� ��rencimizin not ortalamas� : "+ 
            //    notHesaplama.ToString();
            //MessageBox.Show(ifade);

            //string ifade1 = $"{adSoyad} adl� ��rencimizin not ortalamas� : {notHesaplama}";
            //MessageBox.Show(ifade1);

            #endregion
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            #region �kinci Ders                    

            string urunAdi = txt_ProductName.Text;
            double urunFiyati = Convert.ToDouble(txt_UnitPrice.Text);

            double kdvliFiyat = urunFiyati * 1.20;

            label2.Text = $"{urunAdi} isimli �r�n�n %20 kdv dahil fiyat� : {kdvliFiyat}";

            #endregion
        }
    }
}
