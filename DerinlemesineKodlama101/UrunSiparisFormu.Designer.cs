namespace DerinlemesineKodlama101
{
    partial class UrunSiparisFormu
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
            cmbKategoriler = new ComboBox();
            lstListe = new ListBox();
            lstSepet = new ListBox();
            button1 = new Button();
            label2 = new Label();
            nmrAdet = new NumericUpDown();
            label3 = new Label();
            txtBirimFiyat = new TextBox();
            label4 = new Label();
            txtToplamTutar = new TextBox();
            gbxFaturaTipi = new GroupBox();
            rdBireysel = new RadioButton();
            rdKurumsal = new RadioButton();
            lblSepetToplami = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            gbxFaturaTipi.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 28);
            label1.TabIndex = 0;
            label1.Text = "Lütfen Bir Kategori Seçiniz:";
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(12, 40);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(477, 23);
            cmbKategoriler.TabIndex = 1;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(12, 80);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(477, 184);
            lstListe.TabIndex = 2;
            // 
            // lstSepet
            // 
            lstSepet.FormattingEnabled = true;
            lstSepet.ItemHeight = 15;
            lstSepet.Location = new Point(647, 225);
            lstSepet.Name = "lstSepet";
            lstSepet.Size = new Size(242, 169);
            lstSepet.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(495, 296);
            button1.Name = "button1";
            button1.Size = new Size(118, 63);
            button1.TabIndex = 4;
            button1.Text = ">>>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 277);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Adet";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(12, 296);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(185, 23);
            nmrAdet.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 277);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Birim Fiyat";
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(268, 296);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(221, 23);
            txtBirimFiyat.TabIndex = 8;
            txtBirimFiyat.KeyDown += txtBirimFiyat_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 344);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 7;
            label4.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.Location = new Point(12, 363);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.Size = new Size(477, 23);
            txtToplamTutar.TabIndex = 8;
            // 
            // gbxFaturaTipi
            // 
            gbxFaturaTipi.Controls.Add(rdBireysel);
            gbxFaturaTipi.Controls.Add(rdKurumsal);
            gbxFaturaTipi.Location = new Point(647, 40);
            gbxFaturaTipi.Name = "gbxFaturaTipi";
            gbxFaturaTipi.Size = new Size(242, 168);
            gbxFaturaTipi.TabIndex = 9;
            gbxFaturaTipi.TabStop = false;
            gbxFaturaTipi.Text = "Fatura Tipi";
            // 
            // rdBireysel
            // 
            rdBireysel.AutoSize = true;
            rdBireysel.Font = new Font("Segoe UI", 15F);
            rdBireysel.Location = new Point(23, 82);
            rdBireysel.Name = "rdBireysel";
            rdBireysel.Size = new Size(155, 32);
            rdBireysel.TabIndex = 10;
            rdBireysel.TabStop = true;
            rdBireysel.Text = "Bireysel Fatura";
            rdBireysel.UseVisualStyleBackColor = true;
            // 
            // rdKurumsal
            // 
            rdKurumsal.AutoSize = true;
            rdKurumsal.Font = new Font("Segoe UI", 15F);
            rdKurumsal.Location = new Point(23, 57);
            rdKurumsal.Name = "rdKurumsal";
            rdKurumsal.Size = new Size(170, 32);
            rdKurumsal.TabIndex = 10;
            rdKurumsal.TabStop = true;
            rdKurumsal.Text = "Kurumsal Fatura";
            rdKurumsal.UseVisualStyleBackColor = true;
            // 
            // lblSepetToplami
            // 
            lblSepetToplami.AutoSize = true;
            lblSepetToplami.Font = new Font("Segoe UI", 12F);
            lblSepetToplami.Location = new Point(647, 412);
            lblSepetToplami.Name = "lblSepetToplami";
            lblSepetToplami.Size = new Size(0, 21);
            lblSepetToplami.TabIndex = 10;
            // 
            // UrunSiparisFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 450);
            Controls.Add(lblSepetToplami);
            Controls.Add(lstListe);
            Controls.Add(gbxFaturaTipi);
            Controls.Add(txtToplamTutar);
            Controls.Add(label4);
            Controls.Add(txtBirimFiyat);
            Controls.Add(label3);
            Controls.Add(nmrAdet);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lstSepet);
            Controls.Add(cmbKategoriler);
            Controls.Add(label1);
            Name = "UrunSiparisFormu";
            Text = "UrunSiparisFormu";
            Load += UrunSiparisFormu_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            gbxFaturaTipi.ResumeLayout(false);
            gbxFaturaTipi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbKategoriler;
        private ListBox lstListe;
        private ListBox lstSepet;
        private Button button1;
        private Label label2;
        private NumericUpDown nmrAdet;
        private Label label3;
        private TextBox txtBirimFiyat;
        private Label label4;
        private TextBox txtToplamTutar;
        private GroupBox gbxFaturaTipi;
        private RadioButton rdBireysel;
        private RadioButton rdKurumsal;
        private Label lblSepetToplami;
    }
}