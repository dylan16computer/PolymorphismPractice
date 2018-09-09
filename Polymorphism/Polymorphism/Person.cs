using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Person
    {
        public string Name { get; set; }
        public virtual string PrintDetails()
        {
            return $"Your name is {Name}"; //any instance created under the Person class (e.g. Person person1 = new Person();) will use this method when calling PrintDetails()
        }
        public Person(string _name)
        {
            Name = _name;
        }
    }
    class Student : Person
    {
        static int i = 0;
        public override string PrintDetails()
        {
            i += 1;
            return $"{base.PrintDetails()} who is student {i}"; //any instance created under the Student class (e.g. Person student1 = new Student();) will use this method when calling PrintDetails()
            //base.PrintDetails() retains the return string. If base.PrintDetails is not specified, the return string will be completely overwritten/erased upon use of this method
        }
        public Student(string _name) : base(_name) //inheriting the Person _name variable to set the private property with
        {
            Name = _name;
        }
    }
}
