using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("universite ismi eklemek için 1 basın\n " +
                "bölüme öğretim elemanı atama için 3 e ve silme için 4 e\n " +
                "ders açma için 5 e ve kapama için 6 ya\n" +
                " derse öğretim elemanı atama için 7'ye ve değiştirme için 8 e\n " +
                "derse öğrenci ekleme için 9 a ve silme için 10 a basın\n" +
                "bölümlere öğrenci kayıt etmek için 11 e ve silme için 12 ye\n");
            string degisken;
            int secim = 1;
            try//try catch hata yakalama
            {
                secim = Int32.Parse(Console.ReadLine());
            }
            
            catch (yazimHatasi e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Bir hata oluştu!");
            }
            
            switch (secim)//istenilen işlemi seçme
            {
                case 1:
                    {
                        degisken = Console.ReadLine();
                        universite okul = new universite();
                        okul.UniversiteAdi = degisken;
                        break;
                    }
                
                case 3:
                    {
                        degisken = Console.ReadLine();
                        ogretimElemanı eleman = new ogretimElemanı();
                        eleman.OgretimElemanıAdi.Add(degisken);
                        break;
                    }
                case 4:
                    {
                        degisken = Console.ReadLine();
                        ogretimElemanı eleman = new ogretimElemanı();
                        eleman.OgretimElemanıAdi.Remove(degisken);
                        break;
                    }
                case 5:
                    {
                        degisken = Console.ReadLine();
                        ders ders = new ders();
                        ders.DersAdi = degisken;
                        break;
                    }
                case 6:
                    {
                        
                        break;
                    }
                case 7:
                    {
                        degisken = Console.ReadLine();
                        ders ders = new ders();
                        ders.OgretimElemanıAdi.Add(degisken);
                        break;
                    }
                case 8:
                    {
                        degisken = Console.ReadLine();
                        ders ders = new ders();
                        ders.OgretimElemanıAdi.Remove(degisken);
                        break;
                    }
                case 9:
                    {
                        degisken = Console.ReadLine();
                        ders ders = new ders();
                        ders.OgrenciAdi.Add(degisken);
                        break;
                    }
                case 10:
                    {
                        degisken = Console.ReadLine();
                        ders ders = new ders();
                        ders.OgrenciAdi.Remove(degisken);

                        break;
                    }
                case 11:
                    {
                        degisken = Console.ReadLine();
                        bolum Bolum = new bolum();
                        Bolum.OgrenciAdi.Add(degisken);
                        break;
                    }
                case 12:
                    {
                        degisken = Console.ReadLine();
                        bolum Bolum = new bolum();
                        Bolum.OgrenciAdi.Remove(degisken);
                        break;
                    }





            }
            Console.ReadLine();
        }
        
    }

}
