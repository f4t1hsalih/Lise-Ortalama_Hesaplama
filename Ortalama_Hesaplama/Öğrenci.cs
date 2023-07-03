namespace Ortalama_Hesaplama
{
    class Öğrenci
    {
        private string ad;
        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }

        }

        private string soyad;
        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        private string tckimlikno;
        public string Tckimlikno
        {
            get
            {
                return tckimlikno;
            }

            set
            {
                tckimlikno = value;
            }
        }

        double ortalama;
        public string Durum(double not1, double not2, double not3)
        {
            string sonuç;
            ortalama = (not1 + not2 + not3) / 3;
            if (ortalama >= 50) sonuç = Ad + " " + Soyad + " " + Tckimlikno + "\n" + "Geçti , Ortalaması: " + ortalama;
            else sonuç = Ad + " " + Soyad + " " + Tckimlikno + "\n" + "Kaldı , Ortalaması: " + ortalama; ;
            return sonuç;
        }
    }
}
