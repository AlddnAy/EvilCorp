namespace VTS
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            button1 = new Button();
            epost_lbl = new Label();
            e_mask = new MaskedTextBox();
            par_mask = new MaskedTextBox();
            lbl_par = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(226, 312);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(176, 27);
            button1.TabIndex = 0;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // epost_lbl
            // 
            epost_lbl.AutoSize = true;
            epost_lbl.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            epost_lbl.Location = new Point(30, 172);
            epost_lbl.Margin = new Padding(4, 0, 4, 0);
            epost_lbl.Name = "epost_lbl";
            epost_lbl.Size = new Size(89, 24);
            epost_lbl.TabIndex = 1;
            epost_lbl.Text = "E-Posta:";
            // 
            // e_mask
            // 
            e_mask.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            e_mask.Location = new Point(191, 172);
            e_mask.Margin = new Padding(4, 3, 4, 3);
            e_mask.Name = "e_mask";
            e_mask.Size = new Size(256, 26);
            e_mask.TabIndex = 3;
            // 
            // par_mask
            // 
            par_mask.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            par_mask.Location = new Point(191, 247);
            par_mask.Margin = new Padding(4, 3, 4, 3);
            par_mask.Name = "par_mask";
            par_mask.PasswordChar = '*';
            par_mask.Size = new Size(256, 26);
            par_mask.TabIndex = 4;
            // 
            // lbl_par
            // 
            lbl_par.AutoSize = true;
            lbl_par.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_par.Location = new Point(38, 249);
            lbl_par.Margin = new Padding(4, 0, 4, 0);
            lbl_par.Name = "lbl_par";
            lbl_par.Size = new Size(77, 24);
            lbl_par.TabIndex = 5;
            lbl_par.Text = "Parola:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(36, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 6;
            label3.Text = "Giriş Yap";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(14, 543);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 13);
            label4.TabIndex = 8;
            label4.Text = "EVIL Corp.";
            // 
            // button3
            // 
            button3.Location = new Point(292, 538);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(176, 27);
            button3.TabIndex = 9;
            button3.Text = "Yapımcı Girişi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 31);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(108, 538);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(176, 27);
            button4.TabIndex = 11;
            button4.Text = "Yönetici Girişi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(485, 597);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_par);
            Controls.Add(par_mask);
            Controls.Add(e_mask);
            Controls.Add(epost_lbl);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label epost_lbl;
        private System.Windows.Forms.MaskedTextBox e_mask;
        private System.Windows.Forms.MaskedTextBox par_mask;
        private System.Windows.Forms.Label lbl_par;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
    }
}

