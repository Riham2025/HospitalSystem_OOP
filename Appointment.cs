using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem_OOP
{
    class Appointment
    {
        // Properties for Appointment class
        private int appointmentId;
        private Doctor doctor;
        private Patient patient;
        private DateTime appointmentDate;

        // Default constructor
        public int AppointmentId { get => appointmentId; set => appointmentId = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }


        // Overloaded constructor for Appointment class
        public Appointment(int id, Doctor doctor, Patient patient, DateTime date)
        {
            appointmentId = id;
            this.doctor = doctor;
            this.patient = patient;
            appointmentDate = date;
        }

        public void Display() // Method to display appointment details
        {
            Console.WriteLine($"Appointment ID: {appointmentId}, Doctor: {doctor.Name}, Patient: {patient.Name}, Date: {appointmentDate}");
        }
    }
}
