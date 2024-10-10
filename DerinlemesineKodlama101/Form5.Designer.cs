namespace DerinlemesineKodlama101
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_aranan = new TextBox();
            btn_bul = new Button();
            lst_Liste = new ListBox();
            label2 = new Label();
            txt_cumle = new TextBox();
            btn_ara = new Button();
            btn_dizi = new Button();
            label3 = new Label();
            label4 = new Label();
            lbl_sonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 43);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Aranan harf";
            // 
            // txt_aranan
            // 
            txt_aranan.Location = new Point(21, 75);
            txt_aranan.Name = "txt_aranan";
            txt_aranan.Size = new Size(300, 23);
            txt_aranan.TabIndex = 1;
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(21, 206);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(134, 23);
            btn_bul.TabIndex = 2;
            btn_bul.Text = "Bul ve Değiştir";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // lst_Liste
            // 
            lst_Liste.FormattingEnabled = true;
            lst_Liste.ItemHeight = 15;
            lst_Liste.Location = new Point(455, 33);
            lst_Liste.Name = "lst_Liste";
            lst_Liste.Size = new Size(146, 349);
            lst_Liste.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 123);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "Aranan cümle";
            // 
            // txt_cumle
            // 
            txt_cumle.Location = new Point(21, 155);
            txt_cumle.Name = "txt_cumle";
            txt_cumle.Size = new Size(300, 23);
            txt_cumle.TabIndex = 1;
            // 
            // btn_ara
            // 
            btn_ara.Location = new Point(246, 206);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(75, 23);
            btn_ara.TabIndex = 4;
            btn_ara.Text = "Arama Yap";
            btn_ara.UseVisualStyleBackColor = true;
            btn_ara.Click += btn_ara_Click;
            // 
            // btn_dizi
            // 
            btn_dizi.Location = new Point(115, 264);
            btn_dizi.Name = "btn_dizi";
            btn_dizi.Size = new Size(162, 23);
            btn_dizi.TabIndex = 5;
            btn_dizi.Text = "Dizide Arama Yap";
            btn_dizi.UseVisualStyleBackColor = true;
            btn_dizi.Click += btn_dizi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // lbl_sonuc
            // 
            lbl_sonuc.AutoSize = true;
            lbl_sonuc.Location = new Point(184, 33);
            lbl_sonuc.Name = "lbl_sonuc";
            lbl_sonuc.Size = new Size(0, 15);
            lbl_sonuc.TabIndex = 0;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_dizi);
            Controls.Add(btn_ara);
            Controls.Add(lst_Liste);
            Controls.Add(btn_bul);
            Controls.Add(txt_cumle);
            Controls.Add(label2);
            Controls.Add(txt_aranan);
            Controls.Add(lbl_sonuc);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_aranan;
        private Button btn_bul;
        private ListBox lst_Liste;
        private Label label2;
        private TextBox txt_cumle;
        private Button btn_ara;
        private Button btn_dizi;
        private Label label3;
        private Label label4;
        private Label lbl_sonuc;
    }
}