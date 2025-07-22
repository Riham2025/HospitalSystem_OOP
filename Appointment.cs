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

        public int AppointmentId { get => appointmentId; set => appointmentId = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }

    }
}
