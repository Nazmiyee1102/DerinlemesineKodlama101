namespace DerinlemesineKodlama101
{
    partial class Form8
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
            btnHesapla = new Button();
            label1 = new Label();
            txtAdSoyad = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            txtVize = new TextBox();
            label3 = new Label();
            txtFinal = new TextBox();
            SuspendLayout();
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(12, 214);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(201, 23);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "Not Ortalaması Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(8, 26);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(205, 23);
            txtAdSoyad.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(254, 8);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(317, 394);
            listBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 62);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Vize";
            // 
            // txtVize
            // 
            txtVize.Location = new Point(8, 91);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(205, 23);
            txtVize.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 126);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 1;
            label3.Text = "Final";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(8, 155);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(205, 23);
            txtFinal.TabIndex = 2;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(txtFinal);
            Controls.Add(label3);
            Controls.Add(txtVize);
            Controls.Add(label2);
            Controls.Add(txtAdSoyad);
            Controls.Add(label1);
            Controls.Add(btnHesapla);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesapla;
        private Label label1;
        private TextBox txtAdSoyad;
        private ListBox listBox1;
        private Label label2;
        private TextBox txtVize;
        private Label label3;
        private TextBox txtFinal;
    }
}