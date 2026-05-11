using System;
using System.Drawing;
using System.Windows.Forms;
using GTranslate.Translators; // NuGet'ten GTranslate yüklü olmalý

namespace CeviriUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TasarimiDuzenle();
        }

        private void TasarimiDuzenle()
        {
            // Form Genel Ayarlarý
            this.Text = "Hýzlý Yan Yana Çeviri";
            this.Size = new Size(850, 450);
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Padding = new Padding(20);

            // Giriþ Kutusu (Sol)
            txtGiris.Multiline = true;
            txtGiris.Size = new Size(380, 250);
            txtGiris.Location = new Point(20, 80);
            txtGiris.Font = new Font("Segoe UI", 11);
            txtGiris.PlaceholderText = "Çevrilecek metni buraya yazýn...";

            // Sonuç Kutusu (Sað)
            txtSonuc.Multiline = true;
            txtSonuc.ReadOnly = true;
            txtSonuc.Size = new Size(380, 250);
            txtSonuc.Location = new Point(430, 80);
            txtSonuc.BackColor = Color.White;
            txtSonuc.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            txtSonuc.PlaceholderText = "Çeviri sonucu burada çýkacak...";

            // Dil Seçimi (Üst)
            cmbDil.Location = new Point(350, 30);
            cmbDil.Size = new Size(130, 30);
            cmbDil.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmbDil.Items.Count == 0)
            {
                cmbDil.Items.AddRange(new string[] { "en", "tr", "de", "fr", "es" });
                cmbDil.SelectedIndex = 0;
            }

            // Çevir Butonu (Alt)
            btnCevir.Text = "Çeviriyi Baþlat";
            btnCevir.Size = new Size(200, 45);
            btnCevir.Location = new Point(315, 345);
            btnCevir.BackColor = Color.DodgerBlue;
            btnCevir.ForeColor = Color.White;
            btnCevir.FlatStyle = FlatStyle.Flat;
            btnCevir.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private async void btnCevir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGiris.Text)) return;

            try
            {
                btnCevir.Enabled = false;
                btnCevir.Text = "Çevriliyor...";
                txtSonuc.Text = "Lütfen bekleyin...";

                var translator = new GoogleTranslator();
                string hedefDil = cmbDil.SelectedItem.ToString();

                var sonuc = await translator.TranslateAsync(txtGiris.Text, hedefDil);

                txtSonuc.Text = sonuc.Translation;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ýnternet veya Baðlantý Hatasý: " + ex.Message);
                txtSonuc.Text = "Hata oluþtu!";
            }
            finally
            {
                btnCevir.Enabled = true;
                btnCevir.Text = "Çeviriyi Baþlat";
            }
        }
    }
}