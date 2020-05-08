using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NtcBulmaYardimcisi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Shown(object sender, EventArgs e)
        {
            Sensör_Başlat();

            group_sensör.Enabled = false;
            NTC_Başlat();
            group_sensör.Enabled = true;
        }

        #region Sensor
        private void Sensör_Başlat()
        {
            Sensör_Arama.Tag = 0;
            int tick = Environment.TickCount + 100;
            group_sensör.Enabled = false;

            if (!File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\Sensor\\Liste.csv"))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\Sensor");
                File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\Sensor\\Liste.csv",
                    "Üretici,ÜreticiKodu,Açıklama,Pdf(Dosya yolu),T1 (-##.###),R1Min (##.###),R1Mak (-#.#),T2,R2Min,R2Mak,T3,R3Min,R3Mak,..." + Environment.NewLine +
                    "ArgeMup,HtcHesaplamaYardimcisi,NTC değerlerini hesaplar,C:\\xxx\\yyy," + 
                    "-10.5,900.9,1100.1," + 
                    "25,450,550," + 
                    "150,45,55, ... gibi " + Environment.NewLine +
                    "ArgeMup2,HtcHesaplamaYardimcisi2,NTC değerlerini hesaplar2,C:\\xxx2\\yyy2," +
                    "-10.5,900.9,1100.1," +
                    "25,450,550," +
                    "150,45,55, ... gibi ");
            }

            o.Sensörler.Clear();

            string[] gecici_liste = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "\\Sensor\\Liste.csv");
            for (int a = 1; a < gecici_liste.Length; a++)
            {
                try
                {
                    //fazladan virgül içeren metinlerin düzenlenmesi
                    string[] aa = gecici_liste[a].Split(',');
                    for (int aa_ = 0; aa_ < aa.Length; aa_++) { aa[aa_] = aa[aa_].Replace("_ArgeMuP_", ","); }

                    SensörHesap_ sh = new SensörHesap_();
                    sh.Üretici = aa[0].ToUpper();
                    sh.ÜreticiKodu = aa[1].ToUpper();
                    sh.Açıklama = aa[2];
                    sh.Pdf = aa[3].Trim(' ', '/', '\\'); ;

                    int kalinan = 4;
                    while (aa.Length >= kalinan + 3)
                    {
                        SensörHesap_.BirSıcaklık_ biri = new SensörHesap_.BirSıcaklık_();
                        if (double.TryParse(aa[kalinan + 0], o.style, o.culture, out biri.SıcaklıkDeğeri))
                        {
                            if (double.TryParse(aa[kalinan + 1], o.style, o.culture, out biri.Rmin))
                            {
                                if (double.TryParse(aa[kalinan + 2], o.style, o.culture, out biri.Rmak))
                                {
                                    sh.R_T_Tablosu.Add(biri);
                                }
                            }
                        }
                        kalinan += 3;  
                    }

                    bool bulundu = false;
                    for (int c = 0; c < o.Sensörler.Count && !bulundu; c++)
                    {
                        if (o.Sensörler[c].ÜreticiKodu == sh.ÜreticiKodu) bulundu = true;
                    }

                    if (!bulundu) o.Sensörler.Add(sh);

                    if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }
                }
                catch (Exception) { }
            }

            Sensör_Arama.Text = "";
            Sensör_ler.Items.Clear();

            foreach (var b in o.Sensörler)
            {
                Sensör_ler.Items.Add(b.ÜreticiKodu);

                if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }
            }
            toolTip1.SetToolTip(Sensör_ler, Sensör_ler.Items.Count + " Sensör");

            group_sensör.Enabled = true;
        }
        private void Sensor_Arama_TextChanged(object sender, EventArgs e)
        {
            Sensör_Arama.Tag = (int)Sensör_Arama.Tag + 1;

            if ((int)Sensör_Arama.Tag > 1) return;

            Sensör_Arama_Yap();
        }
        private void Sensör_Arama_Yap()
        {
            int tick = Environment.TickCount + 100;

        YenidenDene:
            string aranan = Sensör_Arama.Text.ToUpper();
            Sensör_ler.Items.Clear();
            Sensör_Arama.Tag = 1;

            foreach (var a in o.Sensörler)
            {
                if (a.Üretici.Contains(aranan) || a.ÜreticiKodu.Contains(aranan)) Sensör_ler.Items.Add(a.ÜreticiKodu);

                if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }

                if ((int)Sensör_Arama.Tag > 1) goto YenidenDene;
            }

            Sensör_Arama.Tag = 0;
        }
        private void Sensor_ler_DoubleClick(object sender, EventArgs e)
        {
            var lb = (sender as ListBox);
            if (lb.SelectedIndex < 0) return;

            foreach (var a in o.Sensörler)
            {
                if (a.ÜreticiKodu == lb.SelectedItem.ToString())
                {
                    Sensör_Bilgileri yeni = new Sensör_Bilgileri(a);
                    yeni.Font = Font;
                    yeni.Show();
                }
            }
        }
        #endregion

        #region NTC
        private void NTC_Başlat()
        {
            Ntc_Arama.Tag = 0;
            int tick = Environment.TickCount + 100;
            if (!File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\Ntc\\Liste.csv")) { new MlzListesiniOlusturma().ShowDialog(); }
            if (!File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\Ntc\\Liste.csv")) { Application.Exit(); return; }
            group_ntc.Enabled = false;

            o.Ntcler.Clear();

            string[] gecici_liste = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "\\Ntc\\Liste.csv");
            for (int a = 1; a < gecici_liste.Length; a++)
            {
                try
                {
                    bool Sorunlu = false;

                    //fazladan virgül içeren metinlerin düzenlenmesi
                    string[] aa = gecici_liste[a].Split(',');
                    for (int aa_ = 0; aa_ < aa.Length; aa_++) { aa[aa_] = aa[aa_].Replace("_ArgeMuP_", ","); }

                    NtcHesap_ nh = new NtcHesap_();
                    nh.Üretici = aa[0];
                    nh.ÜreticiKodu = aa[1];
                    nh.Açıklama = aa[2];
                    nh.Pdf = aa[13].Trim(' ', '/', '\\'); ;

                    //-40°C ~ 150°C -> -40 150
                    var çs = aa[3].Split(' ');
                    if (!double.TryParse(çs[0].Trim('°', 'C'), o.style, o.culture, out nh.ÇalışmaSıcaklığı_Düşük))
                    {
                        Sorunlu = true;
                        //Console.WriteLine("Satır " + (a+1) + " ÇalışmaSıcaklığı_Düşük");
                        //continue;
                    }
                    if (!double.TryParse(çs[çs.Length - 1].Trim('°', 'C'), o.style, o.culture, out nh.ÇalışmaSıcaklığı_Yüksek))
                    {
                        Sorunlu = true;
                        //Console.WriteLine("Satır " + (a + 1) + " ÇalışmaSıcaklığı_Yüksek");
                        //continue;
                    }

                    //25°C -> 25
                    if (!double.TryParse(aa[4].Trim('°', 'C'), o.style, o.culture, out nh.ReferansNoktası_Sıcaklık))
                    {
                        Sorunlu = true;
                        //Console.WriteLine("Satır " + (a + 1) + " ReferansNoktası_Sıcaklık");
                        //continue;
                    }

                    //100K -> 100000
                    if (!double.TryParse(aa[5].ToUpper().Trim('K', 'M'), o.style, o.culture, out nh.ReferansNoktası_Direnç))
                    {
                        Sorunlu = true;
                        //Console.WriteLine("Satır " + (a + 1) + " ReferansNoktası_Direnç");
                        //continue;
                    }
                    if (aa[5].ToUpper().Contains("K")) nh.ReferansNoktası_Direnç *= 1000;
                    else if (aa[5].ToUpper().Contains("M")) nh.ReferansNoktası_Direnç *= 1000 * 1000;

                    //±1% -> 1
                    if (!double.TryParse(aa[6].Trim('±', '%', '°', 'C'), o.style, o.culture, out nh.ReferansNoktası_HataOranı))
                    {
                        Sorunlu = true;
                        //Console.WriteLine("Satır " + (a + 1) + " ReferansNoktası_HataOranı");
                        //continue;
                    }
                    if (!double.TryParse(aa[7].Trim('±', '%'), o.style, o.culture, out nh.Beta_HataOranı))
                    {
                        Sorunlu = true;
                        //Console.WriteLine("Satır " + (a + 1) + " Beta_HataOranı");
                        //continue;
                    }

                    for (int b = 0; b < 5; b++)
                    {
                        double betttta = 0;
                        if (double.TryParse(aa[8 + b].ToUpper().Trim('K'), o.style, o.culture, out betttta))
                        {
                            bool bulundu = false;
                            nh.GörünenAdı = nh.ÜreticiKodu.ToUpper() + " " + betttta;

                            for (int c = 0; c < o.Ntcler.Count && !bulundu; c++)
                            {
                                if (o.Ntcler[c].GörünenAdı == nh.GörünenAdı) { bulundu = true; break; }
                            }

                            if (!bulundu)
                            {
                                NtcHesap_ yeni = new NtcHesap_();
                                yeni.Açıklama = nh.Açıklama;
                                yeni.Beta = betttta;
                                yeni.Beta_HataOranı = nh.Beta_HataOranı;
                                yeni.Pdf = nh.Pdf;
                                yeni.ReferansNoktası_Direnç = nh.ReferansNoktası_Direnç;
                                yeni.ReferansNoktası_HataOranı = nh.ReferansNoktası_HataOranı;
                                yeni.ReferansNoktası_Sıcaklık = nh.ReferansNoktası_Sıcaklık;
                                yeni.ÇalışmaSıcaklığı_Düşük = nh.ÇalışmaSıcaklığı_Düşük;
                                yeni.ÇalışmaSıcaklığı_Yüksek = nh.ÇalışmaSıcaklığı_Yüksek;
                                yeni.Üretici = nh.Üretici;
                                yeni.ÜreticiKodu = nh.ÜreticiKodu;
                                yeni.GörünenAdı = Sorunlu ? "*" + nh.GörünenAdı : nh.GörünenAdı;

                                o.Ntcler.Add(yeni);
                            }
                        }
                    }
                }
                catch (Exception) { }

                if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }
            }

            Ntc_Arama.Text = "";
            Ntc_ler.Items.Clear();

            foreach (var b in o.Ntcler)
            {
                Ntc_ler.Items.Add(b.GörünenAdı);

                if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }
            }
            toolTip1.SetToolTip(Ntc_ler, Ntc_ler.Items.Count + " NTC");

            group_ntc.Enabled = true;
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

        YenidenDene:
            string aranan = Ntc_Arama.Text.ToUpper();
            Ntc_ler.Items.Clear();
            Ntc_Arama.Tag = 1;

            foreach (var a in o.Ntcler)
            {
                if (a.GörünenAdı.Contains(aranan)) Ntc_ler.Items.Add(a.GörünenAdı);

                if (Environment.TickCount > tick) { tick = Environment.TickCount + 100; Application.DoEvents(); }

                if ((int)Ntc_Arama.Tag > 1) goto YenidenDene;
            }

            Ntc_Arama.Tag = 0;
        }
        private void Ntc_ler_DoubleClick(object sender, EventArgs e)
        {
            var lb = (sender as ListBox);
            if (lb.SelectedIndex < 0) return;

            foreach (var a in o.Ntcler)
            {
                if (a.GörünenAdı == lb.SelectedItem.ToString())
                {
                    Ntc_Bilgileri yeni = new Ntc_Bilgileri(a);
                    yeni.Font = Font;
                    yeni.Show();
                }
            }
        }
        #endregion

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            string a = string.Format("mailto:{0}?Subject={1}&Body={2}", "mup.arge@gmail.com", "Ntc Bulma Yardımcısı Hk.", "Mesajınız");
            System.Diagnostics.Process.Start(a);
        }
        private void Menu_aA_100_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 8);
        }
        private void Menu_aA_125_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 10);
        }
        private void Menu_aA_150_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 12);
        }
        private void Menu_aA_175_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 14);
        }
        private void Menu_aA_200_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 16);
        }
    }
}
