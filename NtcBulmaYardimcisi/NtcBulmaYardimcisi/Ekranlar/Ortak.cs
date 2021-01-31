using System;
using System.Collections.Generic;

namespace NtcBulmaYardimcisi
{
    static class o
    {
        static public List<SensörHesap_> Sensörler = new List<SensörHesap_>();
        static public List<NtcHesap_> Ntcler = new List<NtcHesap_>();

        static public System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Number;
        static public System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

        //static public System.Drawing.Point L_NtcBilgileri, L_SensörBilgileri;
        //static public System.Drawing.Size S_NtcBilgileri, S_SensörBilgileri;

        static public string D2S(double G)
        {
            if (G < 10) return G.ToString("F3");
            else if (G < 100) return G.ToString("F2");
            else if (G < 1000) return G.ToString("F1");
            else return G.ToString("F0");
        }
    }

    public struct NtcHesap_
    {
        public string GörünenAdı;
        public string Üretici;
        public string ÜreticiKodu;
        public string Açıklama;
        public string Pdf;

        public double ÇalışmaSıcaklığı_Düşük;
        public double ÇalışmaSıcaklığı_Yüksek;

        public double ReferansNoktası_Sıcaklık;
        public double ReferansNoktası_Direnç;
        public double ReferansNoktası_HataOranı;

        public double Beta;
        public double Beta_HataOranı;

        public NtcHesap_(string GörünenAd = "")
        {
            GörünenAdı = GörünenAd;
            Üretici = "";
            ÜreticiKodu = "";
            Açıklama = "";
            Pdf = "";

            ÇalışmaSıcaklığı_Düşük = double.MaxValue;
            ÇalışmaSıcaklığı_Yüksek = double.MinValue;

            ReferansNoktası_Sıcaklık = double.MinValue;
            ReferansNoktası_Direnç = double.MinValue;
            ReferansNoktası_HataOranı = double.MaxValue;

            Beta = double.MaxValue;
            Beta_HataOranı = double.MaxValue;
    }
        public double Rnor(double Sıcaklık)
        {
            //if (Sıcaklık > ÇalışmaSıcaklığı_Yüksek) return double.MinValue;
            //if (Sıcaklık < ÇalışmaSıcaklığı_Düşük) return double.MaxValue;
            if (Sıcaklık > ÇalışmaSıcaklığı_Yüksek) return 0;
            if (Sıcaklık < ÇalışmaSıcaklığı_Düşük) return 0;

            return ReferansNoktası_Direnç * Math.Exp(Beta * ((1 / (Sıcaklık + 273.15)) - (1 / (ReferansNoktası_Sıcaklık + 273.15))));
        }
        public double Rmak(double Sıcaklık)
        {
            if (Sıcaklık > ÇalışmaSıcaklığı_Yüksek) return 0;
            if (Sıcaklık < ÇalışmaSıcaklığı_Düşük) return 0;

            double normal = Rnor(Sıcaklık);

            return normal + (normal / 100.0 * HataOranı(Sıcaklık));
        }
        public double Rmin(double Sıcaklık)
        {
            if (Sıcaklık > ÇalışmaSıcaklığı_Yüksek) return 0;
            if (Sıcaklık < ÇalışmaSıcaklığı_Düşük) return 0;

            double normal = Rnor(Sıcaklık);

            return normal - (normal / 100.0 * HataOranı(Sıcaklık));
        }
        public double HataOranı(double Sıcaklık)
        {
            if (Sıcaklık > ÇalışmaSıcaklığı_Yüksek) return 100;
            if (Sıcaklık < ÇalışmaSıcaklığı_Düşük) return 100;

            return Math.Abs(ReferansNoktası_HataOranı) + Math.Abs(Beta_HataOranı * Beta * ((1 / (Sıcaklık + 273.15)) - (1 / (ReferansNoktası_Sıcaklık + 273.15))));
        }
    }

    public class SensörHesap_
    {
        public string Üretici = "";
        public string ÜreticiKodu = "";
        public string Açıklama = "";
        public string Pdf = "";

        public struct BirSıcaklık_
        {
            public double SıcaklıkDeğeri;
            public double Rmin, Rmak;
        }
        public List<BirSıcaklık_> R_T_Tablosu = new List<BirSıcaklık_>();

        public void Başlat(string Üretici, string ÜreticiKodu, string Açıklama, string Pdf,
                           List<BirSıcaklık_> R_T_Tablosu)
        {
            this.Üretici = Üretici;
            this.ÜreticiKodu = ÜreticiKodu;
            this.Açıklama = Açıklama;
            this.Pdf = Pdf;

            this.R_T_Tablosu = R_T_Tablosu;
        }
    }
}
