namespace DerinlemesineKodlama101
{
    partial class Form4
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
            lst_Liste = new ListBox();
            btn_for = new Button();
            txt_for = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // lst_Liste
            // 
            lst_Liste.FormattingEnabled = true;
            lst_Liste.ItemHeight = 15;
            lst_Liste.Location = new Point(400, 64);
            lst_Liste.Name = "lst_Liste";
            lst_Liste.Size = new Size(208, 349);
            lst_Liste.TabIndex = 0;
            // 
            // btn_for
            // 
            btn_for.Location = new Point(56, 296);
            btn_for.Name = "btn_for";
            btn_for.Size = new Size(75, 23);
            btn_for.TabIndex = 1;
            btn_for.Text = "for 1";
            btn_for.UseVisualStyleBackColor = true;
            btn_for.Click += btn_for_Click;
            // 
            // txt_for
            // 
            txt_for.Location = new Point(56, 251);
            txt_for.Name = "txt_for";
            txt_for.Size = new Size(209, 23);
            txt_for.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(148, 296);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "for 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 338);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "for 3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(190, 338);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "while 1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(148, 367);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "do while";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(56, 367);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "foreach";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_for);
            Controls.Add(btn_for);
            Controls.Add(lst_Liste);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_Liste;
        private Button btn_for;
        private TextBox txt_for;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}