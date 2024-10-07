namespace DerinlemesineKodlama101
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            txt_AdSoyad = new TextBox();
            txt_TCKimlik = new TextBox();
            txt_DersNotu = new TextBox();
            txt_UnitPrice = new TextBox();
            txt_ProductName = new TextBox();
            btn_hesapla = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(236, 247);
            button1.Name = "button1";
            button1.Size = new Size(126, 37);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(119, 119);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad";
            // 
            // txt_AdSoyad
            // 
            txt_AdSoyad.Location = new Point(122, 159);
            txt_AdSoyad.Name = "txt_AdSoyad";
            txt_AdSoyad.Size = new Size(240, 23);
            txt_AdSoyad.TabIndex = 2;
            // 
            // txt_TCKimlik
            // 
            txt_TCKimlik.Location = new Point(122, 188);
            txt_TCKimlik.Name = "txt_TCKimlik";
            txt_TCKimlik.Size = new Size(240, 23);
            txt_TCKimlik.TabIndex = 2;
            // 
            // txt_DersNotu
            // 
            txt_DersNotu.Location = new Point(122, 218);
            txt_DersNotu.Name = "txt_DersNotu";
            txt_DersNotu.Size = new Size(240, 23);
            txt_DersNotu.TabIndex = 2;
            // 
            // txt_UnitPrice
            // 
            txt_UnitPrice.Location = new Point(415, 189);
            txt_UnitPrice.Name = "txt_UnitPrice";
            txt_UnitPrice.Size = new Size(240, 23);
            txt_UnitPrice.TabIndex = 5;
            // 
            // txt_ProductName
            // 
            txt_ProductName.Location = new Point(415, 159);
            txt_ProductName.Name = "txt_ProductName";
            txt_ProductName.Size = new Size(240, 23);
            txt_ProductName.TabIndex = 4;
            // 
            // btn_hesapla
            // 
            btn_hesapla.Font = new Font("Segoe UI", 15F);
            btn_hesapla.Location = new Point(529, 218);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(126, 37);
            btn_hesapla.TabIndex = 3;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(415, 279);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 6;
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txt_UnitPrice);
            Controls.Add(txt_ProductName);
            Controls.Add(btn_hesapla);
            Controls.Add(txt_DersNotu);
            Controls.Add(txt_TCKimlik);
            Controls.Add(txt_AdSoyad);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txt_AdSoyad;
        private TextBox txt_TCKimlik;
        private TextBox txt_DersNotu;
        private TextBox txt_UnitPrice;
        private TextBox txt_ProductName;
        private Button btn_hesapla;
        private Label label2;
    }
}
