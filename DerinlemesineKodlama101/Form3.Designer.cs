namespace DerinlemesineKodlama101
{
    partial class Form3
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
            btn_ekle = new Button();
            txt_ogrenciadi = new TextBox();
            SuspendLayout();
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(12, 68);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(261, 23);
            btn_ekle.TabIndex = 0;
            btn_ekle.Text = "Diziye Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // txt_ogrenciadi
            // 
            txt_ogrenciadi.Location = new Point(12, 29);
            txt_ogrenciadi.Name = "txt_ogrenciadi";
            txt_ogrenciadi.Size = new Size(261, 23);
            txt_ogrenciadi.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_ogrenciadi);
            Controls.Add(btn_ekle);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ekle;
        private TextBox txt_ogrenciadi;
    }
}