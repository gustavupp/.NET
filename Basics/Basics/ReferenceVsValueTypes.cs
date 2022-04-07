using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Person
    {
        public string? name;
        public int age;
        public Person(string? name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    internal class ReferenceVsValueTypes
    {
        
        
        static public void Increment(int number)
        {
            number += 10;
        }

        static public void MakeOlder(Person person)
        {
            person.age += 10;
        }

    }
}
