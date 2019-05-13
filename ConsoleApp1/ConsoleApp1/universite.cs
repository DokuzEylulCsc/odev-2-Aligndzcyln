using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class universite
    {
        private string universiteAdi;
        private List<ogrenci> ogrenciler;
        public string UniversiteAdi
        {
            get
            {
                return universiteAdi;
            }
            set
            {
                universiteAdi = value;
            }
        }
        public void ekleogrenci(ogrenci o)
        {
            ogrenciler.Add(o);
        }
        public ogrenci ogrenciAra(int no)
        {
            ogrenci t = null;
            foreach(ogrenci a in ogrenciler)
            {
                if (int.Equals(a.OgrenciNo, no))
                {
                    t = a;
                    break;
                }
            }
            if (t == null) throw new ogrenciBulunamadi(no);
            return t;
        }
        public ogrenci ogrenciAra(string isim)
        {
            ogrenci t = null;
            foreach (ogrenci a in ogrenciler)
            {
                if (a.İsim == isim)
                {
                    t = a;
                    break;
                }
            }
            if (t == null) throw new ogrenciBulunamadi(isim);
            return t;
        }
    }
    public class fakulte
    {
        private string fakulteAdi;
        public string FakulteAdi
        {
            get
            {
                return fakulteAdi;
            }
            set
            {
                fakulteAdi = value;
            }
        }
        private List<bolum> bolumler;
        public List<bolum> Bolumler
        {
            get
            {
                return bolumler;
            }
            set
            {
                bolumler = value;
            }
        }


    }
    public class bolum
    {
        private string bolumAdı;
        public string BolumAdi
        {
            get
            {
                return bolumAdı;
            }
            set
            {
                bolumAdı = value;
            }
        }
        private List<ders> dersler;
        public List<ders> Dersler
        {
            get
            {
                return dersler;
            }
            set
            {
                dersler = value;
            }
        }

    }
    public class ders
    {
        private string dersAdi;
        public string DersAdi
        {
            get
            {
                return dersAdi;
            }
            set
            {
                dersAdi = value;
            }
        }
    }
    public class sube
    {
        private string subeAdi;
        public string SubeAdi
        {
            get
            {
                return subeAdi;
            }
            set
            {
                subeAdi = value;
            }
        }
    }
    public class ogretimElemanı
    {
        private List<string> ogretimElemanıAdi;
        public List<string> OgretimElemanıAdi
        {
            get
            {
                return ogretimElemanıAdi;
            }
            set
            {
                ogretimElemanıAdi = value;
            }
        }
    }
}
