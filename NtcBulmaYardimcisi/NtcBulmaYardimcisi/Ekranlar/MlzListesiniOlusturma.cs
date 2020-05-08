using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace NtcBulmaYardimcisi
{
    public partial class MlzListesiniOlusturma : Form
    {
        public MlzListesiniOlusturma()
        {
            InitializeComponent();
        }
        private void MlzListesiniOlusturma_Load(object sender, EventArgs e)
        {
            Liste.Rows.Clear();
            Liste.RowCount = 2;
            Liste.TopLeftHeaderCell.Value = "Dağıtıcı";

            int Satır = 0;
            Liste.Rows[Satır].HeaderCell.Value = "Digikey";
            Liste[0, Satır].Value = "?";
            Liste[1, Satır].Value = "https://www.digikey.com/products/en/sensors-transducers/temperature-sensors-ntc-thermistors/508?FV=-8%7C508&quantity=0&ColumnSort=0&page=1&k=ntc&pageSize=500";// "https://www.digikey.com/products/en/sensors-transducers/temperature-sensors-ntc-thermistors/508?k=ntc";

            //Satır++;
            //Liste.Rows[Satır].HeaderCell.Value = "Mouser";
            //Liste[0, Satır].Value = "? / ?";
            //Liste[1, Satır].Value = "https://www.mouser.com.tr/Circuit-Protection/Thermistors/NTC-Thermistors/_/N-axfvt?Keyword=ntc&FS=True";
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            Guncelle.Enabled = false;
            int tick = Environment.TickCount + 100;
            var doc = new HtmlDocument();
            int Satır = -1;
            int ToplamNtcSayısı = 0;
            int ToplamSayfaSayısı = 0;

            if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\Ntc\\Liste.csv")) File.Move(Path.GetDirectoryName(Application.ExecutablePath) + "\\Ntc\\Liste.csv", Path.GetDirectoryName(Application.ExecutablePath) + "\\Ntc\\Liste_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv");
            Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\Ntc");
            var Dosya = File.AppendText(Path.GetDirectoryName(Application.ExecutablePath) + "\\Ntc\\Liste.csv");
            Dosya.AutoFlush = false;
            Dosya.WriteLine("Üretici,ÜreticiKodu,Açıklama,ÇalışmaSıcaklığı," +
                            "Ref_SicaklıkDeğeri,Ref_SicaklıkDirençDeğeri,Ref_HataPayı," +
                            "B_HataPayı,B0_50,B25_50,B25_75,B25_85,B25_100," +
                            "Pdf");
            
            #region Digikey
            Satır++;
            string SonrakiSayfa = Liste[1, 0].Value.ToString();

            while (!string.IsNullOrEmpty(SonrakiSayfa))
            { 
                doc.LoadHtml(SayfayıAl(SonrakiSayfa));
                //doc.LoadHtml(System.IO.File.ReadAllText(@"D:\DANDİK YEDEKLER\Digikey Ornekleri\digikey ntc.html"));
                SonrakiSayfa = "";
                ToplamSayfaSayısı++;

                var Mlzler = doc.GetElementbyId("lnkPart");
                foreach (var n in Mlzler.ChildNodes)
                {
                    if (n.Name != "tr") continue;

                    string Üretici = "", ÜreticiKodu = "", Pdf = "", Açıklama = "", ÇalışmaSıcaklığı = "";
                    string Ref_SicaklıkDeğeri = "25", Ref_SicaklıkDirençDeğeri = "", Ref_HataPayı = "";
                    string B_HataPayı = "", B0_50 = "", B25_50 = "", B25_75 = "", B25_85 = "", B25_100 = "";

                    foreach (var m in n.ChildNodes)
                    {
                     
                        if (m.Name != "td") continue;

                        var o = m.Attributes["class"];
                        switch (o.Value)
                        {
                            case "tr-datasheet":
                                try
                                {
                                    Pdf = m.ChildNodes["a"].Attributes["href"].Value.Trim('\r', '\n', ' ');
                                }
                                catch (Exception) { }
                                break;

                            case "tr-vendor":
                                try
                                {
                                   Üretici = m.ChildNodes["span"].ChildNodes["a"].ChildNodes["span"].InnerText.Trim('\r', '\n', ' ');
                                }
                                catch (Exception) { }
                                break;

                            case "tr-mfgPartNumber":
                                try
                                {
                                    ÜreticiKodu = m.ChildNodes["a"].ChildNodes["span"].InnerText.Trim('\r', '\n', ' ');
                                }
                                catch (Exception) { }
                                break;

                            case "tr-description":
                                Açıklama = m.InnerText.Trim('\r', '\n', ' ');
                                break;

                            case "CLS 866 ptable-param": //ref sıcaklık direnç değeri
                                Ref_SicaklıkDirençDeğeri = m.InnerText.Trim('\r', '\n', ' ');
                                break;

                            case "CLS 867 ptable-param": //ref hata payı
                                Ref_HataPayı = m.InnerText.Trim('\r', '\n', ' ');
                                break;

                            case "CLS 865 ptable-param": //beta hata payı
                                B_HataPayı = m.InnerText.Trim('\r', '\n', ' ');
                                break;

                            case "CLS 861 ptable-param": //B0/50
                                B0_50 = m.InnerText.Trim('\r', '\n', ' ', '-');
                                break;

                            case "CLS 862 ptable-param": //B25/50
                                B25_50 = m.InnerText.Trim('\r', '\n', ' ', '-');
                                break;

                            case "CLS 898 ptable-param": //B25/75
                                B25_75 = m.InnerText.Trim('\r', '\n', ' ', '-');
                                break;

                            case "CLS 863 ptable-param": //B25/85
                                B25_85 = m.InnerText.Trim('\r', '\n', ' ', '-');
                                break;

                            case "CLS 864 ptable-param": //B25/100
                                B25_100 = m.InnerText.Trim('\r', '\n', ' ', '-');
                                break;

                            case "CLS 252 ptable-param": //çalışma sıcaklığı
                                ÇalışmaSıcaklığı = m.InnerText.Trim('\r', '\n', ' ');
                                break;

                            default:
                                break;
                        }
                    }

                    Üretici = Üretici.Replace(",", "_ArgeMuP_");
                    ÜreticiKodu = ÜreticiKodu.Replace(",", "_ArgeMuP_");
                    Açıklama = Açıklama.Replace(",", "_ArgeMuP_");
                    ÇalışmaSıcaklığı = ÇalışmaSıcaklığı.Replace(",", "_ArgeMuP_");
                    Ref_SicaklıkDeğeri = Ref_SicaklıkDeğeri.Replace(",", "_ArgeMuP_");
                    Ref_SicaklıkDirençDeğeri = Ref_SicaklıkDirençDeğeri.Replace(",", "_ArgeMuP_");
                    Ref_HataPayı = Ref_HataPayı.Replace(",", "_ArgeMuP_");
                    B_HataPayı = B_HataPayı.Replace(",", "_ArgeMuP_");
                    B0_50 = B0_50.Replace(",", "_ArgeMuP_");
                    B25_50 = B25_50.Replace(",", "_ArgeMuP_");
                    B25_75 = B25_75.Replace(",", "_ArgeMuP_");
                    B25_85 = B25_85.Replace(",", "_ArgeMuP_");
                    B25_100 = B25_100.Replace(",", "_ArgeMuP_");
                    Pdf = Pdf.Replace(",", "_ArgeMuP_");

                    string birarada = Üretici + "," +
                                        ÜreticiKodu + "," +
                                        Açıklama + "," +
                                        ÇalışmaSıcaklığı + "," +
                                        Ref_SicaklıkDeğeri + "," +
                                        Ref_SicaklıkDirençDeğeri + "," +
                                        Ref_HataPayı + "," +
                                        B_HataPayı + "," +
                                        B0_50 + "," +
                                        B25_50 + "," +
                                        B25_75 + "," +
                                        B25_85 + "," +
                                        B25_100 + "," +
                                        Pdf;
                    Dosya.WriteLine(birarada);
                    ++ToplamNtcSayısı;

                    if (Environment.TickCount > tick) 
                    {
                        Liste[0, Satır].Value = ToplamSayfaSayısı + " / " + ToplamNtcSayısı;
                        tick = Environment.TickCount + 100; 
                        Application.DoEvents(); 
                    }
                }

                var SnrkSyfa = doc.GetElementbyId("content");
                foreach (var m in SnrkSyfa.ChildNodes)
                {
                    try
                    {
                        if (m.Name != "div") continue;

                        var n = m.Attributes["class"];
                        if (n == null) continue;
                        if (n.Value != "btm-wrapper") continue;

                        foreach (var o in m.ChildNodes)
                        {
                            if (o.Name != "div") continue;

                            var oo = o.Attributes["class"];
                            if (oo == null) continue;
                            if (oo.Value != "page-slector") continue;

                            foreach (var p in o.ChildNodes)
                            {
                                if (p.Name != "div") continue;

                                var pp = p.Attributes["class"];
                                if (pp == null) continue;
                                if (pp.Value != "paging") continue;

                                foreach (var r in p.ChildNodes)
                                {
                                    if (r.Name != "div") continue;

                                    var rr = r.Attributes["class"];
                                    if (rr == null) continue;
                                    if (rr.Value != "paging-inner") continue;

                                    foreach (var s in r.ChildNodes)
                                    {
                                        var ss = s.Attributes["class"];
                                        if (ss == null) continue;
                                        if (ss.Value != "Next") continue;

                                        ss = s.Attributes["href"];
                                        if (ss == null) continue;

                                        SonrakiSayfa = Liste[1, Satır].Value.ToString(); ;
                                        SonrakiSayfa = SonrakiSayfa.Replace("page=1", "page=" + (ToplamSayfaSayısı + 1).ToString());
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception) { }
                }
            }
            Liste[0, Satır].Value = ToplamSayfaSayısı + " / " + ToplamNtcSayısı;
            #endregion

            Dosya.Close();
            Guncelle.Enabled = true;
        }

        WebClient client = null;
        string SayfayıAl(string url)
        {
            if (client == null)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                client = new WebClient();
            }

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)");
            client.Headers.Add("Content-Type", "application / zip, application / octet - stream");

            return System.Text.Encoding.UTF8.GetString(client.DownloadData(url));
        }
    }
}
