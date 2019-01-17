class ogrenci
    {
        private string _ad="";
        private string _soyad="";
        private string _no="";
        private double _ort=0;
        

        #region Accesor ve Mutator
        public string GetAd()              //public string Ad {get; set; }
        {
            return _ad;
        }
        public void SetAd(string ad)
        {
            _ad = ad;
        }
        public string GetSoyad()           //public string Soyad {get; set; }
        {
            return _soyad;
        }
        public void SetSoyad(string soyad)
        {
            _soyad = soyad;
        }
        public string GetNo()              //public string No { get; set; }
        {
            return _no;
        }
        public void SetNo(string n)
        {
            _no = n;
        }
        public double GetOrtalama()
        {
            return _ort;
        }
        public void SetOrtalama(double o)
        {
            if (o >= 0 && o <= 4)
                _ort = o;
            else
                throw new Exception("Ortalama 0 ile 4 arasında olmalıdır!");
        }
        #endregion

        public ogrenci(string ad, string soyad, string no)
        {
            _ad = ad;
            _soyad = soyad;
            _no = no;
            _ort = 0;
        }
        public ogrenci(string ad, string soyad, string no, double ort)
        {
            _ad = ad;
            _soyad = soyad;
            _no = no;
            _ort = ort;
        }
        public ogrenci()
        {
            
        }

        public override string ToString()
        {
            return _ad + " " + _soyad + " " + _no + " " + _ort;
        }

        public static ogrenci operator +(ogrenci k1, ogrenci k2)
        {
            ogrenci k3 = new ogrenci();
            k3._ort = k1._ort + k2._ort;
            return k3;
        }

        public static ogrenci operator +(ogrenci k1)
        {
            ogrenci k3 = new ogrenci();
            k3._ort += k1._ort;
            return k3;
        }

        public static ogrenci operator /(ogrenci k1, double sayi)
        {
            ogrenci k3 = new ogrenci();
            k3._ort = k1._ort / sayi;
            return k3;
        }
    }
