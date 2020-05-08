using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NtcBulmaYardimcisi
{
    public partial class Ntc_Bilgileri : Form
    {
        NtcHesap_ Nh;
        string NotlarKonumu = "";

        public Ntc_Bilgileri(NtcHesap_ NtcHesap)
        {
            InitializeComponent();
            Nh = NtcHesap;
        }

        private void Ntc_Bilgileri_Load(object sender, EventArgs e)
        {
            Liste.Rows.Clear();
            Liste.TopLeftHeaderCell.Value = "T (°C)";

            this.Text = Nh.Açıklama;
            Girdi_Üretici.Text = Nh.Üretici;
            Girdi_ÜreticiKodu.Text = Nh.ÜreticiKodu;
            Girdi_ÇalışmaSıcaklığı.Text = Nh.ÇalışmaSıcaklığı_Düşük + " " + Nh.ÇalışmaSıcaklığı_Yüksek;
            
            Girdi_Beta.Value = (decimal)Nh.Beta; if (Girdi_Beta.Value == 0) Girdi_Beta.BackColor = Color.Yellow;
            Girdi_Beta_HataOranı.Value = (decimal)Nh.Beta_HataOranı; if (Girdi_Beta_HataOranı.Value == 0) Girdi_Beta_HataOranı.BackColor = Color.Yellow;
            Girdi_Ref_T.Value = (decimal)Nh.ReferansNoktası_Sıcaklık; if (Girdi_Ref_T.Value == 0) Girdi_Ref_T.BackColor = Color.Yellow;
            Girdi_Ref_R.Value = (decimal)Nh.ReferansNoktası_Direnç; if (Girdi_Ref_R.Value == 0) Girdi_Ref_R.BackColor = Color.Yellow;
            Girdi_Ref_HataOranı.Value = (decimal)Nh.ReferansNoktası_HataOranı; if (Girdi_Ref_HataOranı.Value == 0) Girdi_Ref_HataOranı.BackColor = Color.Yellow;
            Girdi_EnDüşük.Value = (decimal)Nh.ÇalışmaSıcaklığı_Düşük; if (Girdi_EnDüşük.Value == 0) Girdi_EnDüşük.BackColor = Color.Yellow;
            Girdi_EnYüksek.Value = (decimal)Nh.ÇalışmaSıcaklığı_Yüksek; if (Girdi_EnYüksek.Value == 0) Girdi_EnYüksek.BackColor = Color.Yellow;

            toolTip1.SetToolTip(Girdi_Pdf, Nh.Pdf);

            NotlarKonumu = Path.GetDirectoryName(Application.ExecutablePath) + "\\Ntc\\Notlar\\" + Nh.GörünenAdı + "K.mup";
            if (File.Exists(NotlarKonumu))
            {
                Girdi_Notlar.Text = File.ReadAllText(NotlarKonumu);
                if (!string.IsNullOrEmpty(Girdi_Notlar.Text)) Notlar_Butonu.ForeColor = System.Drawing.Color.Red;
            }

            Girdi_Notlar.Modified = false;
            Girdi_Beta.ValueChanged += new EventHandler(Girdi_Beta_ValueChanged);
            Girdi_Beta_HataOranı.ValueChanged += new EventHandler(Girdi_Beta_HataOranı_ValueChanged);
            Girdi_Ref_T.ValueChanged += new EventHandler(Girdi_Ref_T_ValueChanged);
            Girdi_Ref_R.ValueChanged += new EventHandler(Girdi_Ref_R_ValueChanged);
            Girdi_Ref_HataOranı.ValueChanged += new EventHandler(Girdi_Ref_HataOranı_ValueChanged);
        }

        private void Notlar_Butonu_CheckedChanged(object sender, EventArgs e)
        {
            Girdi_Notlar.Visible = (sender as CheckBox).Checked;
            Liste.Visible = !(sender as CheckBox).Checked;
        }

        private void Hesaplat_Click(object sender, EventArgs e)
        {
            Hesaplat.Enabled = false;

            if (Girdi_EnDüşük.Value > Girdi_EnYüksek.Value)
            {
                decimal gecici = Girdi_EnYüksek.Value;
                Girdi_EnYüksek.Value = Girdi_EnDüşük.Value;
                Girdi_EnDüşük.Value = gecici;
            }

            Liste.RowCount = 0;
            int tick = Environment.TickCount + 100;

            for (decimal i = Girdi_EnDüşük.Value; i <= Girdi_EnYüksek.Value; i+=Girdi_Aralık.Value)
            {
                Liste.RowCount++;
                Liste.Rows[Liste.RowCount - 1].HeaderCell.Value = i.ToString();
                Liste[0, Liste.RowCount - 1].Value = o.D2S(Nh.Rnor((double)i));
                Liste[1, Liste.RowCount - 1].Value = o.D2S(Nh.Rmin((double)i));
                Liste[2, Liste.RowCount - 1].Value = o.D2S(Nh.Rmak((double)i));
                Liste[3, Liste.RowCount - 1].Value = o.D2S(Nh.HataOranı((double)i));
                if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }
            }

            Hesaplat.Enabled = true;
        }

        public void BirSatırlıkİşlem_Başlat()
        {
            Liste.RowCount = 0;
        }
        public void BirSatırlıkİşlem_Ekle(double Sıcaklık)
        {
            Liste.RowCount++;
            Liste.Rows[Liste.RowCount - 1].HeaderCell.Value = Sıcaklık.ToString();
            Liste[0, Liste.RowCount - 1].Value = o.D2S(Nh.Rnor(Sıcaklık));
            Liste[1, Liste.RowCount - 1].Value = o.D2S(Nh.Rmin(Sıcaklık));
            Liste[2, Liste.RowCount - 1].Value = o.D2S(Nh.Rmak(Sıcaklık));
            Liste[3, Liste.RowCount - 1].Value = o.D2S(Nh.HataOranı(Sıcaklık)); 
        }

        private void Girdi_Pdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(toolTip1.GetToolTip(Girdi_Pdf));
            }
            catch (Exception) { }
        }

        private void Ntc_Bilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Girdi_Notlar.Modified) return;
            
            DialogResult result = MessageBox.Show("Değişiklikleri kaydetmek istiyor musun?", "Notlar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(Girdi_Notlar.Text))
                {
                    if (File.Exists(NotlarKonumu)) File.Delete(NotlarKonumu);
                }
                else
                {
                    string klasör = Path.GetDirectoryName(NotlarKonumu);
                    Directory.CreateDirectory(klasör);
                    File.WriteAllText(NotlarKonumu, Girdi_Notlar.Text);
                }
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Girdi_Beta_ValueChanged(object sender, EventArgs e)
        {
            Nh.Beta = (double)Girdi_Beta.Value;
            Girdi_Beta.ForeColor = Color.Red;
        }
        private void Girdi_Beta_HataOranı_ValueChanged(object sender, EventArgs e)
        {
            Nh.Beta_HataOranı = (double)Girdi_Beta_HataOranı.Value;
            Girdi_Beta_HataOranı.ForeColor = Color.Red;
        }
        private void Girdi_Ref_T_ValueChanged(object sender, EventArgs e)
        {
            Nh.ReferansNoktası_Sıcaklık = (double)Girdi_Ref_T.Value;
            Girdi_Ref_T.ForeColor = Color.Red;
        }
        private void Girdi_Ref_R_ValueChanged(object sender, EventArgs e)
        {
            Nh.ReferansNoktası_Direnç = (double)Girdi_Ref_R.Value;
            Girdi_Ref_R.ForeColor = Color.Red;
        }
        private void Girdi_Ref_HataOranı_ValueChanged(object sender, EventArgs e)
        {
            Nh.ReferansNoktası_HataOranı = (double)Girdi_Ref_HataOranı.Value;
            Girdi_Ref_HataOranı.ForeColor = Color.Red;
        }
    }
}
