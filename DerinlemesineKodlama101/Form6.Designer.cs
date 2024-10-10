namespace DerinlemesineKodlama101
{
    partial class Form6
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
            btn_oyna = new Button();
            listBox1 = new ListBox();
            btn_uret = new Button();
            SuspendLayout();
            // 
            // btn_oyna
            // 
            btn_oyna.Location = new Point(12, 322);
            btn_oyna.Name = "btn_oyna";
            btn_oyna.Size = new Size(239, 37);
            btn_oyna.TabIndex = 0;
            btn_oyna.Text = "Oyna";
            btn_oyna.UseVisualStyleBackColor = true;
            btn_oyna.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(239, 304);
            listBox1.TabIndex = 1;
            // 
            // btn_uret
            // 
            btn_uret.Location = new Point(12, 365);
            btn_uret.Name = "btn_uret";
            btn_uret.Size = new Size(239, 46);
            btn_uret.TabIndex = 2;
            btn_uret.Text = "Benzersiz Sayı Üret";
            btn_uret.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_uret);
            Controls.Add(listBox1);
            Controls.Add(btn_oyna);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_oyna;
        private ListBox listBox1;
        private Button btn_uret;
    }
}