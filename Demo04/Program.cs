using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a Teacher object
            Teacher teacher = new Teacher();
            teacher.FirstName = "Kalle";
            teacher.LastName = "Konsoli";
            teacher.Address = "Piippukatu 2";
            teacher.Age = 40;
            teacher.PhoneNumber = "044-1231234";
            teacher.Room = "D546";
            Console.WriteLine(teacher.ToString());

            //create a Student object
            Student student = new Student("Olli","Opiskelija","K1234");
            student.Address = "Polttolinja 3 a 6";
            student.Age = 21;
            student.PhoneNumber = "040-2342345";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
        }
    }
}
