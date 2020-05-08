using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NtcBulmaYardimcisi
{
    public partial class Sensör_Bilgileri : Form
    {
        SensörHesap_ Sh = null;
        string NotlarKonumu = "", NtclerKonumu = "";
        List<snç_> Ağırlıklar = null;

        public Sensör_Bilgileri(SensörHesap_ SensörHesap)
        {
            InitializeComponent();
            Sh = SensörHesap;
        }

        private void Sensör_Bilgileri_Load(object sender, EventArgs e)
        {
            this.Text = Sh.Açıklama;
            Girdi_Üretici.Text = Sh.Üretici;
            Girdi_ÜreticiKodu.Text = Sh.ÜreticiKodu;
            Ntc_Arama.Tag = 0;

            toolTip1.SetToolTip(Girdi_Pdf, Sh.Pdf);

            Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\Sensor\\" + Sh.ÜreticiKodu);

            NotlarKonumu = Path.GetDirectoryName(Application.ExecutablePath) + "\\Sensor\\" + Sh.ÜreticiKodu + "\\" + "Notlar.mup";
            if (File.Exists(NotlarKonumu))
            {
                Girdi_Notlar.Text = File.ReadAllText(NotlarKonumu);
                if (!string.IsNullOrEmpty(Girdi_Notlar.Text)) Notlar_Butonu.ForeColor = System.Drawing.Color.Red;
            }
            Girdi_Notlar.Modified = false;

            Liste.Rows.Clear();
            foreach (var a in Sh.R_T_Tablosu)
            {
                Liste.RowCount++;
                Liste[0, Liste.RowCount - 1].Value = o.D2S(a.SıcaklıkDeğeri);
                Liste[1, Liste.RowCount - 1].Value = o.D2S(a.Rmin);
                Liste[2, Liste.RowCount - 1].Value = o.D2S(a.Rmak);
            }

            Ntc_ler.Items.Clear();
            NtclerKonumu = Path.GetDirectoryName(Application.ExecutablePath) + "\\Sensor\\" + Sh.ÜreticiKodu + "\\" + "Ntcler.mup";
            if (File.Exists(NtclerKonumu))
            {
                Ntc_ler.Items.AddRange(File.ReadAllLines(NtclerKonumu));
                if (Ntc_ler.Items.Count > 0) Ntc_ler.SelectedIndex = 0;   
            }
        }

        private void Notlar_Butonu_CheckedChanged(object sender, EventArgs e)
        {
            Girdi_Notlar.Visible = (sender as CheckBox).Checked;
            Liste.Visible = !(sender as CheckBox).Checked;
        }

        private void Araştır_Click(object sender, EventArgs e)
        {
            Araştır.Enabled = false;

            Ntc_ler.Items.Clear();
            Ağırlıklar = new List<snç_>();
            int tick = Environment.TickCount + 100;

            for (int i = 0; i < o.Ntcler.Count; i++)
            {
                snç_ snç = new snç_();
                snç.indis = i;
                snç.Ağırlık = 0;

                foreach (var sıcaklık in Sh.R_T_Tablosu)
                {
                    snç.Ağırlık += Ağırlığı(sıcaklık.Rmin, o.Ntcler[i].Rmin(sıcaklık.SıcaklıkDeğeri), true);
                    snç.Ağırlık += Ağırlığı(o.Ntcler[i].Rmak(sıcaklık.SıcaklıkDeğeri), sıcaklık.Rmak, false);

                    if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }
                }
                snç.Ağırlık /= Sh.R_T_Tablosu.Count * 2;

                Ağırlıklar.Add(snç);
            }

            GFG gg = new GFG();
            Ağırlıklar.Sort(gg);

            foreach (var a in Ağırlıklar)
            {
                if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }

                Ntc_ler.Items.Add(o.Ntcler[a.indis].GörünenAdı);
            }

            if (Ntc_ler.Items.Count > 0)
            {
                if (File.Exists(NtclerKonumu)) File.Delete(NtclerKonumu);
                StreamWriter SaveFile = new StreamWriter(NtclerKonumu);
                foreach (var item in Ntc_ler.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.Flush();
                SaveFile.Close();
            }

            Ntc_ler.SelectedIndex = 0;
            Araştır.Enabled = true;
        }
        double Ağırlığı(double T1, double T2, bool T1_Sensor)
        {
            //double sonuç;
            //////////////////////////////////////////////////////////////

            //sonuç = ((T1 - T2) / (T1 + T2));

            //sonuç = ((T1 - T2) / ((T1 + T2)/2));

            //sonuç = ((T1 - T2) / (T1 * T2));

            //Rmin  SENSOR      NTC
            //      20 - 100    40 - 80
            double fark = 0;
            if (T1_Sensor)
            {
                //T1 sen T2 ntc
                fark = T1 - T2;
                if (fark <= 0) return 0;

                return fark / T1 * 100.0;
            }
            else 
            {
                //T1 ntc T2 sen
                fark = T1 - T2;
                if (fark < 0) return 0;
                
                return fark / T2 * 100.0;
            }

            //if (T1_Sensor) sonuç = ((T1 - T2) / (T1));
            //else sonuç = ((T1 - T2) / (T2));

            //////////////////////////////////////////////////////////////
            //return sonuç > 0 ? sonuç : 0;
        }

        private void Girdi_Pdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(toolTip1.GetToolTip(Girdi_Pdf));
            }
            catch (Exception) { }
        }

        private void Ntc_ler_DoubleClick(object sender, EventArgs e)
        {
            ListBox lb = (sender as ListBox);
            if (lb.SelectedIndex < 0) return;

            foreach (var ntc in o.Ntcler)
            {
                if (ntc.GörünenAdı == lb.SelectedItem.ToString()) 
                {
                    Ntc_Bilgileri yeni_ekran = new Ntc_Bilgileri(ntc);
                    yeni_ekran.Font = Font;
                    yeni_ekran.Show();
                    yeni_ekran.BirSatırlıkİşlem_Başlat();
                    foreach (var R_T in Sh.R_T_Tablosu) yeni_ekran.BirSatırlıkİşlem_Ekle(R_T.SıcaklıkDeğeri);

                    break; 
                }
            } 
        }

        private void Ntc_ler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ntc_ler.SelectedIndex < 0) return;
            Ntc_ler.Enabled = false;

            if (Ağırlıklar != null) toolTip1.SetToolTip(Ntc_ler, "% " + o.D2S(Ağırlıklar[Ntc_ler.SelectedIndex].Ağırlık) + " " + Ntc_ler.SelectedItem.ToString());

            NtcHesap_ ntc = new NtcHesap_();
            foreach (var a in o.Ntcler) if (a.GörünenAdı == Ntc_ler.SelectedItem.ToString()) { ntc = a; break; }

            Grafik.Series.Clear();
            Grafik.ChartAreas[0].CursorX.IsUserEnabled = true;
            Grafik.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            Grafik.ChartAreas[0].CursorY.IsUserEnabled = true;
            Grafik.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            Series NSensör = Grafik.Series.Add("Sensör");
            NSensör.ChartType = SeriesChartType.Range;
            NSensör.Color = Color.YellowGreen;

            Series Nntc = Grafik.Series.Add("Ntc");
            Nntc.ChartType = SeriesChartType.Range;
            Nntc.Color = Color.White;

            for (int a = 0; a < Sh.R_T_Tablosu.Count; a++)
            {
                NSensör.Points.AddXY(Sh.R_T_Tablosu[a].SıcaklıkDeğeri, GrafikİçinDüzenle(Sh.R_T_Tablosu[a].Rmak), GrafikİçinDüzenle(Sh.R_T_Tablosu[a].Rmin));
                Nntc.Points.AddXY(Sh.R_T_Tablosu[a].SıcaklıkDeğeri, GrafikİçinDüzenle(ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri)), GrafikİçinDüzenle(ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri)));

                double Ağırlık = Ağırlığı(Sh.R_T_Tablosu[a].Rmin, ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri), true);
                if (Ağırlık <= 0)
                {
                    Liste[1, a].Style.BackColor = Color.YellowGreen;
                    Liste[1, a].ToolTipText = "NTC : " + o.D2S(ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri));
                }
                else
                {
                    Liste[1, a].ToolTipText = "Sensör : " + o.D2S(Sh.R_T_Tablosu[a].Rmin) + Environment.NewLine +
                        "NTC    : " + o.D2S(ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri)) + Environment.NewLine +
                        "Fark   : " + o.D2S(Math.Abs(Sh.R_T_Tablosu[a].Rmin - ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri))) + " Ω" + Environment.NewLine +
                        "% " + o.D2S(Ağırlık);

                    if (Ağırlık > (double)Yüzde.Value) Liste[1, a].Style.BackColor = Color.OrangeRed;
                    else Liste[1, a].Style.BackColor = Color.Gold;
                }

                Ağırlık = Ağırlığı(ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri), Sh.R_T_Tablosu[a].Rmak, false);
                if (Ağırlık <= 0)
                {
                    Liste[2, a].Style.BackColor = Color.YellowGreen;
                    Liste[2, a].ToolTipText = "NTC : " + o.D2S(ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri));
                }
                else
                {
                    Liste[2, a].Style.BackColor = Color.OrangeRed;
                    Liste[2, a].ToolTipText = "Sensör : " + o.D2S(Sh.R_T_Tablosu[a].Rmak) + Environment.NewLine +
                        "NTC    : " + o.D2S(ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri)) + Environment.NewLine +
                        "Fark   : " + o.D2S(Math.Abs(ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri) - Sh.R_T_Tablosu[a].Rmak)) + " Ω" + Environment.NewLine +
                        "% " + o.D2S(Ağırlık);

                    if (Ağırlık > (double)Yüzde.Value) Liste[2, a].Style.BackColor = Color.OrangeRed;
                    else Liste[2, a].Style.BackColor = Color.Gold;
                }

                //if (ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri) >= Sh.R_T_Tablosu[a].Rmin &&
                //    ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri) <= Sh.R_T_Tablosu[a].Rmak)
                //{
                //    Liste[1, a].Style.BackColor = Color.YellowGreen;
                //    Liste[1, a].ToolTipText = "NTC : " + ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri);
                //}
                //else 
                //{
                //    double fark = Math.Abs(Sh.R_T_Tablosu[a].Rmin - ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri));

                //    Liste[1, a].ToolTipText = "Sensör : " + Sh.R_T_Tablosu[a].Rmin + Environment.NewLine +
                //        "NTC    : " + ntc.Rmin(Sh.R_T_Tablosu[a].SıcaklıkDeğeri) + Environment.NewLine +
                //        "Fark   : " + fark + " Ω" + Environment.NewLine +
                //        "% " + (fark / Sh.R_T_Tablosu[a].Rmin * 100.0).ToString(); 

                //    double yüzde = Sh.R_T_Tablosu[a].Rmin / 100.0 * (double)this.Yüzde.Value;

                //    if (fark > yüzde) Liste[1, a].Style.BackColor = Color.OrangeRed;
                //    else              Liste[1, a].Style.BackColor = Color.Gold;
                //}

                //if (ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri) <= Sh.R_T_Tablosu[a].Rmak &&
                //    ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri) >= Sh.R_T_Tablosu[a].Rmin)
                //{ 
                //    Liste[2, a].Style.BackColor = Color.YellowGreen;
                //    Liste[2, a].ToolTipText = "NTC : " + ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri);
                //}
                //else
                //{
                //    double fark = Math.Abs(ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri) - Sh.R_T_Tablosu[a].Rmak);

                //    Liste[2, a].Style.BackColor = Color.OrangeRed;
                //    Liste[2, a].ToolTipText = "Sensör : " + Sh.R_T_Tablosu[a].Rmak + Environment.NewLine +
                //        "NTC    : " + ntc.Rmak(Sh.R_T_Tablosu[a].SıcaklıkDeğeri) + Environment.NewLine +
                //        "Fark   : " + fark + " Ω" + Environment.NewLine +
                //        "% " + (fark / Sh.R_T_Tablosu[a].Rmak * 100.0).ToString();

                //    double yüzde = Sh.R_T_Tablosu[a].Rmin / 100.0 * (double)this.Yüzde.Value;

                //    if (fark > yüzde) Liste[2, a].Style.BackColor = Color.OrangeRed;
                //    else Liste[2, a].Style.BackColor = Color.Gold;
                //}
            }

            Ntc_ler.Enabled = true;
            Ntc_ler.Focus();
        }
        double GrafikİçinDüzenle(double girdi)
        {
            if (girdi < 0) return 0;
            else return girdi;
        }

        private void Ntc_Arama_TextChanged(object sender, EventArgs e)
        {
            Ntc_Arama.Tag = (int)Ntc_Arama.Tag + 1;

            if ((int)Ntc_Arama.Tag > 1) return;

            Ntc_Arama_Yap();
        }
        private void Ntc_Arama_Yap()
        {
            int tick = Environment.TickCount + 100;

            string[] tümü = null;
            if (File.Exists(NtclerKonumu)) tümü = File.ReadAllLines(NtclerKonumu);

            YenidenDene:
            string aranan = Ntc_Arama.Text.ToUpper();
            Ntc_ler.Items.Clear(); 
            Ntc_Arama.Tag = 1;

            if (tümü != null)
            {
                foreach (var a in tümü)
                {
                    if (a.Contains(aranan)) Ntc_ler.Items.Add(a);

                    if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }

                    if ((int)Ntc_Arama.Tag > 1) goto YenidenDene;
                }
            }

            Ntc_Arama.Tag = 0;
        }

        private void Sensör_Bilgileri_FormClosing(object sender, FormClosingEventArgs e)
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
    }

    //Karşılaştırıcı
    struct snç_ { public int indis; public double Ağırlık; }
    class GFG : IComparer<snç_>
    {
        int tick = Environment.TickCount + 100;

        public int Compare(snç_ x, snç_ y)
        {
            if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }

            return x.Ağırlık.CompareTo(y.Ağırlık);
        }
    }
}
