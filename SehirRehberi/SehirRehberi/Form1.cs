using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace SehirRehberi
{
    public partial class Form1 : Form
    {
        List<Sehir> sehirler = new List<Sehir>();
        int aktifResimIndex = 0;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(30, 30, 30);

            label2.Text = "MİNİ SEYAHAT REHBERİ";
            label2.ForeColor = Color.Gold;
            label2.Font = new Font("Georgia", 18, FontStyle.Bold);
            label2.TextAlign = ContentAlignment.MiddleCenter;

            label3.Text = "Keşfetmek İstediğiniz Şehri Seçin.";
            label3.ForeColor = Color.Orange;
            label3.Font = new Font("Georgia", 10, FontStyle.Italic);

            comboBoxSehirler.BackColor = Color.FromArgb(45, 45, 45);
            comboBoxSehirler.ForeColor = Color.White;
            comboBoxSehirler.FlatStyle = FlatStyle.Flat;
            comboBoxSehirler.Font = new Font("Georgia", 10);

            btnYukle.BackColor = Color.DarkRed;
            btnYukle.ForeColor = Color.White;
            btnYukle.FlatStyle = FlatStyle.Flat;
            btnYukle.FlatAppearance.BorderSize = 0;
            btnYukle.Font = new Font("Georgia", 10, FontStyle.Bold);

            txtAciklama.BackColor = Color.FromArgb(40, 40, 40);
            txtAciklama.ForeColor = Color.White;
            txtAciklama.Font = new Font("Georgia", 10);
            txtAciklama.BorderStyle = BorderStyle.FixedSingle;

            txtGezilecekYerler.BackColor = Color.FromArgb(40, 40, 40);
            txtGezilecekYerler.ForeColor = Color.White;
            txtGezilecekYerler.Font = new Font("Georgia", 10);
            txtGezilecekYerler.BorderStyle = BorderStyle.FixedSingle;

            picSehir.BackColor = Color.Black;
            picSehir.BorderStyle = BorderStyle.FixedSingle;
            picSehir.SizeMode = PictureBoxSizeMode.StretchImage;

            btnOnceki.BackColor = Color.FromArgb(50, 50, 50);
            btnOnceki.ForeColor = Color.White;
            btnOnceki.FlatStyle = FlatStyle.Flat;
            btnOnceki.Font = new Font("Georgia", 9, FontStyle.Bold);

            btnSonraki.BackColor = Color.FromArgb(50, 50, 50);
            btnSonraki.ForeColor = Color.White;
            btnSonraki.FlatStyle = FlatStyle.Flat;
            btnSonraki.Font = new Font("Georgia", 9, FontStyle.Bold);

            lblResimIndex.ForeColor = Color.Gray;
            lblResimIndex.Font = new Font("Georgia", 9, FontStyle.Italic);
            lblResimIndex.TextAlign = ContentAlignment.MiddleCenter;

            label1.Text = "Gezilecek Yerler";
            label1.ForeColor = Color.Gold;
            label1.Font = new Font("Georgia", 12, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText("sehirler.json");
            sehirler = JsonConvert.DeserializeObject<List<Sehir>>(json);

            foreach (var sehir in sehirler)
            {
                comboBoxSehirler.Items.Add(sehir.sehir);
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if (comboBoxSehirler.SelectedItem == null)
                return;

            string secilen = comboBoxSehirler.SelectedItem.ToString();
            var secilenSehir = sehirler.FirstOrDefault(s => s.sehir == secilen);

            if (secilenSehir != null)
            {
                txtAciklama.Text = secilenSehir.aciklama + Environment.NewLine + Environment.NewLine +
                                   "Hava Durumu: " + secilenSehir.hava;

                txtGezilecekYerler.Text = string.Join(Environment.NewLine, secilenSehir.gezilecekYerler.Split(','));

                aktifResimIndex = 0;
                ResmiGoster(secilenSehir.resimler);
            }
        }

        private void ResmiGoster(List<string> resimler)
        {
            if (resimler.Count == 0) return;

            string resimAdi = resimler[aktifResimIndex];
            string klasorYolu = Path.Combine(Application.StartupPath, "resimler");
            string tamYol = Path.Combine(klasorYolu, resimAdi);

            if (File.Exists(tamYol))
            {
                if (picSehir.Image != null)
                {
                    picSehir.Image.Dispose();
                    picSehir.Image = null;
                }

                using (var stream = new FileStream(tamYol, FileMode.Open, FileAccess.Read))
                {
                    picSehir.Image = Image.FromStream(stream);
                }

                lblResimIndex.Text = $"{aktifResimIndex + 1} / {resimler.Count}";
            }
            else
            {
                picSehir.Image = null;
                lblResimIndex.Text = $"Resim bulunamadı: {resimAdi}";
            }
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            if (comboBoxSehirler.SelectedItem == null) return;

            var secilen = sehirler.FirstOrDefault(s => s.sehir == comboBoxSehirler.SelectedItem.ToString());
            if (secilen == null || secilen.resimler.Count == 0) return;

            if (aktifResimIndex > 0)
            {
                aktifResimIndex--;
                ResmiGoster(secilen.resimler);
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (comboBoxSehirler.SelectedItem == null) return;

            var secilen = sehirler.FirstOrDefault(s => s.sehir == comboBoxSehirler.SelectedItem.ToString());
            if (secilen == null || secilen.resimler.Count == 0) return;

            if (aktifResimIndex < secilen.resimler.Count - 1)
            {
                aktifResimIndex++;
                ResmiGoster(secilen.resimler);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Gerekiyorsa tıklama işlemi buraya
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
