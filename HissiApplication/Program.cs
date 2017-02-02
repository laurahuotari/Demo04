using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            
            do
            {
                Console.Write("Give a new floor number (1-5) > ");
                string line = Console.ReadLine();
                hissi.Kerros = int.Parse(line);

                Console.WriteLine("Elevator is now in floor: " + hissi.Kerros);

            } while (true);

            

        }
    }
}
