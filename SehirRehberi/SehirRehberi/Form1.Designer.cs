namespace SehirRehberi
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
            comboBoxSehirler = new ComboBox();
            btnYukle = new Button();
            txtAciklama = new TextBox();
            picSehir = new PictureBox();
            btnOnceki = new Button();
            btnSonraki = new Button();
            lblResimIndex = new Label();
            txtGezilecekYerler = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picSehir).BeginInit();
            SuspendLayout();
            // 
            // comboBoxSehirler
            // 
            comboBoxSehirler.FormattingEnabled = true;
            comboBoxSehirler.Location = new Point(109, 58);
            comboBoxSehirler.Name = "comboBoxSehirler";
            comboBoxSehirler.Size = new Size(211, 28);
            comboBoxSehirler.TabIndex = 0;
            // 
            // btnYukle
            // 
            btnYukle.Location = new Point(326, 57);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(94, 29);
            btnYukle.TabIndex = 1;
            btnYukle.Text = "Keşfet";
            btnYukle.UseVisualStyleBackColor = true;
            btnYukle.Click += btnYukle_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(109, 91);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.ReadOnly = true;
            txtAciklama.ScrollBars = ScrollBars.Vertical;
            txtAciklama.Size = new Size(314, 128);
            txtAciklama.TabIndex = 2;
            // 
            // picSehir
            // 
            picSehir.Location = new Point(109, 225);
            picSehir.Name = "picSehir";
            picSehir.Size = new Size(314, 161);
            picSehir.SizeMode = PictureBoxSizeMode.StretchImage;
            picSehir.TabIndex = 3;
            picSehir.TabStop = false;
            // 
            // btnOnceki
            // 
            btnOnceki.Location = new Point(109, 387);
            btnOnceki.Name = "btnOnceki";
            btnOnceki.Size = new Size(94, 29);
            btnOnceki.TabIndex = 4;
            btnOnceki.Text = "<<";
            btnOnceki.UseVisualStyleBackColor = true;
            btnOnceki.Click += btnOnceki_Click;
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(329, 387);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(94, 29);
            btnSonraki.TabIndex = 5;
            btnSonraki.Text = ">>";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // lblResimIndex
            // 
            lblResimIndex.AutoSize = true;
            lblResimIndex.Location = new Point(254, 396);
            lblResimIndex.Name = "lblResimIndex";
            lblResimIndex.Size = new Size(21, 20);
            lblResimIndex.TabIndex = 6;
            lblResimIndex.Text = "\"\"";
            // 
            // txtGezilecekYerler
            // 
            txtGezilecekYerler.Location = new Point(109, 454);
            txtGezilecekYerler.Multiline = true;
            txtGezilecekYerler.Name = "txtGezilecekYerler";
            txtGezilecekYerler.ReadOnly = true;
            txtGezilecekYerler.ScrollBars = ScrollBars.Vertical;
            txtGezilecekYerler.Size = new Size(314, 136);
            txtGezilecekYerler.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 419);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 8;
            label1.Text = "Öne Çıkan Yerler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 9;
            label2.Text = "MİNİ SEYAHAT REHBERİ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 34);
            label3.Name = "label3";
            label3.Size = new Size(229, 20);
            label3.TabIndex = 10;
            label3.Text = "Keşfetmek İstediginiz Şehri Seçin.";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 594);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGezilecekYerler);
            Controls.Add(lblResimIndex);
            Controls.Add(btnSonraki);
            Controls.Add(btnOnceki);
            Controls.Add(picSehir);
            Controls.Add(txtAciklama);
            Controls.Add(btnYukle);
            Controls.Add(comboBoxSehirler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picSehir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSehirler;
        private Button btnYukle;
        private TextBox txtAciklama;
        private PictureBox picSehir;
        private Button btnOnceki;
        private Button btnSonraki;
        private Label lblResimIndex;
        private TextBox txtGezilecekYerler;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
