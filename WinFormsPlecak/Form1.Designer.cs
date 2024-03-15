namespace WinFormsPlecak
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
            label2 = new Label();
            label3 = new Label();
            textBox_l_przed = new TextBox();
            textBox_seed = new TextBox();
            textBox_pojemnosc = new TextBox();
            label1 = new Label();
            textBox_wynik = new TextBox();
            textBox_przedmioty = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(257, 98);
            button1.Name = "button1";
            button1.Size = new Size(136, 50);
            button1.TabIndex = 3;
            button1.Text = "run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 158);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 6;
            label3.Text = "pojemność";
            // 
            // textBox_l_przed
            // 
            textBox_l_przed.Location = new Point(44, 41);
            textBox_l_przed.Name = "textBox_l_przed";
            textBox_l_przed.Size = new Size(110, 27);
            textBox_l_przed.TabIndex = 7;
            // 
            // textBox_seed
            // 
            textBox_seed.Location = new Point(44, 110);
            textBox_seed.Name = "textBox_seed";
            textBox_seed.Size = new Size(110, 27);
            textBox_seed.TabIndex = 8;
            // 
            // textBox_pojemnosc
            // 
            textBox_pojemnosc.Location = new Point(44, 181);
            textBox_pojemnosc.Name = "textBox_pojemnosc";
            textBox_pojemnosc.Size = new Size(110, 27);
            textBox_pojemnosc.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 18);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 10;
            label1.Text = "liczb_przedmiotów";
            // 
            // textBox_wynik
            // 
            textBox_wynik.Location = new Point(44, 240);
            textBox_wynik.Multiline = true;
            textBox_wynik.Name = "textBox_wynik";
            textBox_wynik.Size = new Size(290, 183);
            textBox_wynik.TabIndex = 11;
            // 
            // textBox_przedmioty
            // 
            textBox_przedmioty.Location = new Point(467, 31);
            textBox_przedmioty.Multiline = true;
            textBox_przedmioty.Name = "textBox_przedmioty";
            textBox_przedmioty.Size = new Size(286, 392);
            textBox_przedmioty.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_przedmioty);
            Controls.Add(textBox_wynik);
            Controls.Add(label1);
            Controls.Add(textBox_pojemnosc);
            Controls.Add(textBox_seed);
            Controls.Add(textBox_l_przed);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox_l_przed;
        private TextBox textBox_seed;
        private TextBox textBox_pojemnosc;
        private Label label1;
        private TextBox textBox_wynik;
        private TextBox textBox_przedmioty;
    }
}
