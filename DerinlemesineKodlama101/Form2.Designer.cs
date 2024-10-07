namespace DerinlemesineKodlama101
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txt_müsteritutari = new TextBox();
            label1 = new Label();
            lbl_sondurum = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(12, 114);
            button1.Name = "button1";
            button1.Size = new Size(156, 39);
            button1.TabIndex = 0;
            button1.Text = "ve operatörü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(12, 164);
            button2.Name = "button2";
            button2.Size = new Size(156, 39);
            button2.TabIndex = 0;
            button2.Text = "veya operatörü";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(455, 114);
            button3.Name = "button3";
            button3.Size = new Size(107, 25);
            button3.TabIndex = 1;
            button3.Text = "Hesapla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_müsteritutari
            // 
            txt_müsteritutari.Location = new Point(338, 85);
            txt_müsteritutari.Name = "txt_müsteritutari";
            txt_müsteritutari.Size = new Size(224, 23);
            txt_müsteritutari.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 57);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 3;
            label1.Text = "Müşteri Satış Tutarı";
            // 
            // lbl_sondurum
            // 
            lbl_sondurum.AutoSize = true;
            lbl_sondurum.Location = new Point(338, 205);
            lbl_sondurum.Name = "lbl_sondurum";
            lbl_sondurum.Size = new Size(0, 15);
            lbl_sondurum.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_sondurum);
            Controls.Add(label1);
            Controls.Add(txt_müsteritutari);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txt_müsteritutari;
        private Label label1;
        private Label lbl_sondurum;
    }
}