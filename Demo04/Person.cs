using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Person
    {
        //fieds (private)


        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        // default constructor (aina julkinen)
        public Person()
        {
        }

        // constructor takes person firstname and lastname as a parameter

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        // methods
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Address + " " + Age + " " + PhoneNumber;
        }
    }
}
