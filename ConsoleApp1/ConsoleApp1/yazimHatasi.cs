using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        class yazimHatasi : Exception//yazımda oluşacak hatalar için exceptionlar
        {
            public yazimHatasi()
            {
            }

            public yazimHatasi(string message)
            : base(message)
            {
            }

            public yazimHatasi(string message, Exception inner)
            : base(message, inner)
            {
            }
        }
    
}
