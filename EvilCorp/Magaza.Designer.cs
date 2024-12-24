namespace VTS
{
    partial class Magaza
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
            dateTimePicker1 = new DateTimePicker();
            kutuphane = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            mas_sonkul = new MaskedTextBox();
            label12 = new Label();
            txt_kartNo = new TextBox();
            txt_cvv = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txt_isimsoy = new TextBox();
            button4 = new Button();
            txt_isim = new TextBox();
            txt_soyisim = new TextBox();
            label1 = new Label();
            label6 = new Label();
            button1 = new Button();
            txt_oyuncuid = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)kutuphane).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1686, 25);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // kutuphane
            // 
            kutuphane.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kutuphane.Location = new Point(14, 55);
            kutuphane.Margin = new Padding(4, 3, 4, 3);
            kutuphane.Name = "kutuphane";
            kutuphane.Size = new Size(391, 750);
            kutuphane.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(7, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 31);
            label2.TabIndex = 5;
            label2.Text = "Kütüphane";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(900, 145);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 31);
            label3.TabIndex = 6;
            label3.Text = "Bilgi Değişikliği";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(451, 157);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 19);
            label4.TabIndex = 8;
            label4.Text = "Kayıtlı Kartlar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(567, 157);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 23);
            comboBox1.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(587, 435);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 26;
            button3.Text = "Kart Tanımla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // mas_sonkul
            // 
            mas_sonkul.Location = new Point(567, 374);
            mas_sonkul.Mask = "00/0000";
            mas_sonkul.Name = "mas_sonkul";
            mas_sonkul.Size = new Size(191, 23);
            mas_sonkul.TabIndex = 35;
            mas_sonkul.ValidatingType = typeof(DateTime);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(530, 110);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(171, 19);
            label12.TabIndex = 34;
            label12.Text = "Kart Tanımlama Ekranı:";
            // 
            // txt_kartNo
            // 
            txt_kartNo.Location = new Point(567, 208);
            txt_kartNo.Margin = new Padding(5);
            txt_kartNo.Name = "txt_kartNo";
            txt_kartNo.Size = new Size(191, 23);
            txt_kartNo.TabIndex = 33;
            // 
            // txt_cvv
            // 
            txt_cvv.Location = new Point(567, 317);
            txt_cvv.Margin = new Padding(5);
            txt_cvv.Name = "txt_cvv";
            txt_cvv.Size = new Size(191, 23);
            txt_cvv.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(462, 381);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(95, 15);
            label13.TabIndex = 31;
            label13.Text = "Son.Kul. Tarihi:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label14.Location = new Point(508, 317);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(49, 24);
            label14.TabIndex = 30;
            label14.Text = "cvv:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(815, 286);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(67, 15);
            label15.TabIndex = 29;
            label15.Text = "Nickname:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label16.Location = new Point(509, 214);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(48, 14);
            label16.TabIndex = 28;
            label16.Text = "Kart No:";
            // 
            // txt_isimsoy
            // 
            txt_isimsoy.Location = new Point(567, 262);
            txt_isimsoy.Margin = new Padding(5);
            txt_isimsoy.Name = "txt_isimsoy";
            txt_isimsoy.Size = new Size(191, 23);
            txt_isimsoy.TabIndex = 27;
            // 
            // button4
            // 
            button4.Location = new Point(214, 10);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(140, 29);
            button4.TabIndex = 36;
            button4.Text = "Başarım Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txt_isim
            // 
            txt_isim.Location = new Point(909, 278);
            txt_isim.Margin = new Padding(5);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(191, 23);
            txt_isim.TabIndex = 38;
            // 
            // txt_soyisim
            // 
            txt_soyisim.Location = new Point(908, 339);
            txt_soyisim.Margin = new Padding(5);
            txt_soyisim.Name = "txt_soyisim";
            txt_soyisim.Size = new Size(191, 23);
            txt_soyisim.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(474, 265);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 44;
            label1.Text = "İsim-Soyisim:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(827, 347);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 46;
            label6.Text = "parola:";
            // 
            // button1
            // 
            button1.Location = new Point(924, 414);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 51;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txt_oyuncuid
            // 
            txt_oyuncuid.Location = new Point(909, 221);
            txt_oyuncuid.Margin = new Padding(5);
            txt_oyuncuid.Name = "txt_oyuncuid";
            txt_oyuncuid.Size = new Size(191, 23);
            txt_oyuncuid.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(815, 224);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 52;
            label11.Text = "Hesap Id:";
            // 
            // Magaza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 831);
            Controls.Add(txt_oyuncuid);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txt_soyisim);
            Controls.Add(txt_isim);
            Controls.Add(button4);
            Controls.Add(mas_sonkul);
            Controls.Add(label12);
            Controls.Add(txt_kartNo);
            Controls.Add(txt_cvv);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(txt_isimsoy);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(kutuphane);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Magaza";
            Text = "Kullanıcı Ekranı";
            ((System.ComponentModel.ISupportInitialize)kutuphane).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView kutuphane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private Button button3;
        private MaskedTextBox mas_sonkul;
        private Label label12;
        private TextBox txt_kartNo;
        private TextBox txt_cvv;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txt_isimsoy;
        private Button button4;
        private TextBox txt_isim;
        private TextBox txt_soyisim;
        private Label label1;
        private Label label6;
        private Button button1;
        private TextBox txt_oyuncuid;
        private Label label11;
    }
}