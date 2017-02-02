using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Teacher : Person
    {
        public string Room { get; set; }

        //default constructor
        public Teacher()
        {
        }

        // parametric constructor calls base class constructor with parameters
        public Teacher(string firstname, string lastname, string room)
            :base(firstname,lastname) //base on kantaluokka eli Person, aliluokka alustaa kantaluokan parametrejä
        {
            Room = room; 
        }

        //methods
        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Room; // base. kutsuu yliluokan eli Person-luokan ToString()-metodit (return FirstName + " " + ... + Room;)
        }
    }
}
