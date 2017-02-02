using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VahvistinApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvistin = new Vahvistin();
            vahvistin.Volume = 0;

            do
            {
                Console.WriteLine("Give a new volume value (0-100) > ");
                string line = Console.ReadLine();
                vahvistin.Volume = int.Parse(line);

               Console.WriteLine("-> Amplifier volume is set to: " + vahvistin.Volume);
               

            } while (true);
        }
    }
}
