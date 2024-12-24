namespace VTS
{
    partial class YapimciGiris
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
            txt_isim = new TextBox();
            label2 = new Label();
            mas_par = new MaskedTextBox();
            label1 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_isim
            // 
            txt_isim.Location = new Point(103, 112);
            txt_isim.Margin = new Padding(4, 3, 4, 3);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(166, 23);
            txt_isim.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(21, 160);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 11;
            label2.Text = "Parola:";
            // 
            // mas_par
            // 
            mas_par.Location = new Point(103, 160);
            mas_par.Margin = new Padding(4, 3, 4, 3);
            mas_par.Name = "mas_par";
            mas_par.Size = new Size(166, 23);
            mas_par.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(35, 112);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 9;
            label1.Text = "İsim:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(14, 28);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 24);
            label6.TabIndex = 13;
            label6.Text = "Yapımcı Giriş";
            // 
            // button1
            // 
            button1.Location = new Point(103, 210);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // YapimciGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 268);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txt_isim);
            Controls.Add(label2);
            Controls.Add(mas_par);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "YapimciGiris";
            Text = "Yapımcı Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mas_par;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Button button1;
    }
}