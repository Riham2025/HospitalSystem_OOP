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

        public string Specialization { get => specialization; set => specialization = value; }
        public List<DateTime> AvailableAppointments { get => availableAppointments; set => availableAppointments = value; }

        public Doctor(int id, string name, int age, string specialization)
            : base(id, name, age)
        {
            this.specialization = specialization;
            this.availableAppointments = new List<DateTime>();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Doctor: {Name}, Age: {Age}, Specialization: {specialization}");
        }
    }
}
