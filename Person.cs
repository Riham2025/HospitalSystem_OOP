using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem_OOP
{
    class Person //Base class: Person (for inheritance)
    {
        // Fields
        private int id;
        private string name;
        private int age;

        // Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        // Default constructor
        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        // Overloaded constructor
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

    }
}
