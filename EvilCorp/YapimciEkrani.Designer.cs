namespace EvilCorp
{
    partial class YapimciEkrani
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
            txt_id = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Location = new Point(130, 87);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(63, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 1;
            label1.Text = "Hesap Silme";
            // 
            // button1
            // 
            button1.Location = new Point(139, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(41, 91);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 3;
            label2.Text = "Hesap İd:";
            // 
            // YapimciEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 373);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txt_id);
            Name = "YapimciEkrani";
            Text = "YapimciEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}