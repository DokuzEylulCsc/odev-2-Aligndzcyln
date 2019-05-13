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
        public string UniversiteAdi//üniversite adı ekleme
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
        public List<ogrenci> Ogrenciler //ogrenci ekleme
        {
            get
            {
                return ogrenciler;
            }
            set
            {
                ogrenciler = value;
            }
        }
        
    }
    public class fakulte //fakülte ekleme
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
        private List<bolum> bolumler;//fakülteye bölüm ekleme
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
    public class bolum//bölüme ders ekleme
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
        private List<string> ogrenciler; //bölüme öğrenci ekleme
        public List<string> OgrenciAdi
        {

            get
            {
                return ogrenciler;
            }
            set
            {
                ogrenciler = value;
            }
        }

    }
    public class ders //ders ekleme
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
        private List<string> ogretimElemanıAdi;//derse öğretim elemanı atama
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
        private List<string> ogrenciler;//derse öğrenci ekleme
        public List<string> OgrenciAdi
        {

            get
            {
                return ogrenciler;
            }
            set
            {
                ogrenciler = value;
            }
        }
    }
    public class sube//şube ekleme
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
    public class ogretimElemanı//öğretim elemanı ekleme
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
