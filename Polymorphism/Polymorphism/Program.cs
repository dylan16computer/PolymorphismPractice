using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John");
            Console.WriteLine(person1.PrintDetails());
            Person student1 = new Student("Dave");
            Console.WriteLine(student1.PrintDetails());
        }
    }
}
