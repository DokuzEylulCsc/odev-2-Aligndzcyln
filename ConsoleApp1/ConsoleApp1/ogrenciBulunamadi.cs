using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ogrenciBulunamadi:Exception
    {

        public ogrenciBulunamadi() : base()
        {

        }

        public ogrenciBulunamadi(string name) : base($"{name} isimli öğrenci üniversitemize kayıtlı değildir.")
        {

        }
        
        public ogrenciBulunamadi(int StuNo) : base($"{StuNo} numaralı öğrenci universitemize kayıtlı değildir.")
        {

        }
    }
}
