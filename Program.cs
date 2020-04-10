using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Arnold", 20);
                person.GetNameAndAge();

            Teachers teacher = new Teachers("Thomas", 32, "190302", "Math");
                teacher.GetNameAndAge();

            Student student = new Student("Agneez", 18, "10506", "sara123@students.amikom.ac.id");
                student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
