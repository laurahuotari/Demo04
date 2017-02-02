using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Hissi
    {
        private readonly int minKerros = 1;
        private readonly int maxKerros = 5;


        private int kerros = 1;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value > maxKerros)
                {
                    Console.WriteLine("Floor is too big!");
                }

                else if (value < minKerros)
                {
                    Console.WriteLine("Floor is too small!");
                }
                else kerros = value;
                
            }
        }
    }
}
