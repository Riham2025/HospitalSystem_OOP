using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem_OOP
{
    class Patient : Person //Patient class inherits from Person
    {
        private string phoneNumber; // phone number of the patient
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Patient(int id, string name, int age, string phoneNumber)
            : base(id, name, age)
        {
            this.phoneNumber = phoneNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Patient: {Name}, Age: {Age}, Phone: {phoneNumber}");
        }
    }
}
