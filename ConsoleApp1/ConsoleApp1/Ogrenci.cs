using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private string bolumu;
        private string sinif;
        public string İsim
        {
            get
            {
                return isim;
            }
            set
            {
                isim = value;
            }
        }
        public string Soyisim
        {
            get
            {
                return soyisim;
            }
            set
            {
                soyisim = value;
            }
        }
        public int OgrenciNo
        {
            get
            {
                return ogrenciNo;
            }
            set
            {
                ogrenciNo = value;
            }
        }
        public string Bolum
        {
            get
            {
                return bolumu ;
            }
            set
            {
                bolumu = value;
            }
        }
        public string Sinif
        {
            get
            {
                return sinif;
            }
            set
            {
                sinif = value;
            }
        }
        public override string ToString()
        {
            return $"Ad:{isim} Soyad:{soyisim} No:{ogrenciNo} Tip:{this.GetType().Name}";
        }
    }
    public class lisans: ogrenci
    {
        private string seviye = "lisans";
        public string Seviye
        {
            get
            {
                return seviye;
            }
        }
    }
    public class yuksekLisans:ogrenci
    {
        private string seviye = "yüksek lisans";
        public string Seviye
        {
            get
            {
                return seviye;
            }
        }
    }
    public class doktora : ogrenci
    {
        private string seviye = "doktora";
        public string Seviye
        {
            get
            {
                return seviye;
            }
        }
    
    }

}
