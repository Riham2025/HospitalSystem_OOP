using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem_OOP
{
    class Doctor : Person //Doctor class inherits from Person
    {
        private string specialization; //specialization of the doctor
        private List<DateTime> availableAppointments; // list of available appointments for the doctor

        public string Specialization { get => specialization; set => specialization = value; } //specialization property
        public List<DateTime> AvailableAppointments { get => availableAppointments; set => availableAppointments = value; } // list of available appointments property

        public Doctor(int id, string name, int age, string specialization) // Overloaded constructor for Doctor class
            : base(id, name, age)
        {
            this.specialization = specialization;
            this.availableAppointments = new List<DateTime>();
        }

        public override void DisplayInfo() // Overriding the DisplayInfo method from the Person class
        {
           Console.WriteLine($"Doctor: {Name}, Age: {Age}, Specialization: {specialization}"); 
        }
    }
}
