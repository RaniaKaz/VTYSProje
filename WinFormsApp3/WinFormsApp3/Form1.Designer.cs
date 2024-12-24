namespace WinFormsApp3
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
            btn_ekle = new Button();
            btn_sil = new Button();
            btn_guncelle = new Button();
            btn_ara = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            comboBox5 = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_ekle
            // 
            btn_ekle.AccessibleName = "";
            btn_ekle.Location = new Point(1005, 55);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(75, 23);
            btn_ekle.TabIndex = 1;
            btn_ekle.Text = "Ekle";
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(1005, 84);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(75, 23);
            btn_sil.TabIndex = 2;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(1005, 113);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(75, 23);
            btn_guncelle.TabIndex = 3;
            btn_guncelle.Text = "Guncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_ara
            // 
            btn_ara.Location = new Point(1005, 142);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(75, 23);
            btn_ara.TabIndex = 4;
            btn_ara.Text = "Ara";
            btn_ara.UseVisualStyleBackColor = true;
            btn_ara.Click += btn_ara_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(885, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(885, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(837, 63);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "KOD";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sebzeli pizza", "Tavuklu pizza", "Sucuklu pizzza" });
            comboBox2.Location = new Point(650, 319);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(766, 257);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 13;
            label3.Text = "Yemek Secin";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Seftali Suyu", "Cikolatali Sut" });
            comboBox3.Location = new Point(862, 319);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(100, 23);
            comboBox3.TabIndex = 14;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Tiramisu", "Cikolatali kek" });
            comboBox4.Location = new Point(756, 319);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(100, 23);
            comboBox4.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(885, 301);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 16;
            label4.Text = "icecekler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(787, 301);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 17;
            label5.Text = "Tatlilar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(673, 301);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 18;
            label6.Text = "Pizzalar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(815, 121);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 19;
            label7.Text = "Tel Numara";
            // 
            // button1
            // 
            button1.Location = new Point(1005, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(782, 200);
            dataGridView1.TabIndex = 21;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Kapida odeme", "Kredi" });
            comboBox5.Location = new Point(885, 84);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(100, 23);
            comboBox5.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(789, 92);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 23;
            label8.Text = "Odeme yontami";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 460);
            Controls.Add(label8);
            Controls.Add(comboBox5);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_ara);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_sil);
            Controls.Add(btn_ekle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_ekle;
        private Button btn_sil;
        private Button btn_guncelle;
        private Button btn_ara;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox5;
        private Label label8;
    }
}
