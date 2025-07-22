namespace HospitalSystem_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital(); // Create an instance of the Hospital class
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== Hospital System Menu =====");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Add Patient");
                Console.WriteLine("3. Book Appointment");
                Console.WriteLine("4. Show All Appointments");
                Console.WriteLine("5. Show Doctors by Specialization");
                Console.WriteLine("6. Search Appointments by Patient Name");
                Console.WriteLine("7. Search Appointments by Date");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Enter Doctor ID: ");
                        int docId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string docName = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int docAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter Specialization: ");
                        string spec = Console.ReadLine();
                        hospital.AddDoctor(new Doctor(docId, docName, docAge, spec));
                        break;

                    case "2":
                        Console.Write("Enter Patient ID: ");
                        int patId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string patName = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int patAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter Phone Number: ");
                        string phone = Console.ReadLine();
                        hospital.AddPatient(new Patient(patId, patName, patAge, phone));
                        break;

                    case "3":
                        Console.Write("Enter Doctor ID: ");
                        int dId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Patient ID: ");
                        int pId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Appointment Date (yyyy-MM-dd): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        hospital.BookAppointment(dId, pId, date);
                        break;

                    case "4":
                        hospital.ShowAppointments();
                        break;

                    case "5":
                        Console.Write("Enter Specialization: ");
                        string specialization = Console.ReadLine();
                        hospital.ShowDoctorsBySpecialization(specialization);
                        break;

                    case "6":
                        Console.Write("Enter Patient Name: ");
                        string searchName = Console.ReadLine();
                        hospital.SearchAppointmentsByPatientName(searchName);
                        break;

                    case "7":
                        Console.Write("Enter Date (yyyy-MM-dd): ");
                        DateTime searchDate = DateTime.Parse(Console.ReadLine());
                        hospital.SearchAppointmentsByDate(searchDate);
                        break;

                    case "0":
                        running = false;
                        Console.WriteLine("Exiting");
                        break;

                    default:
                        Console.WriteLine(" Invalid option.");
                        break;
                }
            }
        }
        public class Hospital
        {
            // Properties for Hospital class
            private List<Doctor> doctors = new List<Doctor>(); 
            private List<Patient> patients = new List<Patient>();
            private List<Appointment> appointments = new List<Appointment>();
            private int appointmentCounter = 1;

            public void AddDoctor(Doctor doctor) // Method to add a doctor
            {
                doctors.Add(doctor);
            }

            public void AddPatient(Patient patient) // Method to add a patient
            {
                patients.Add(patient);
            }

            public void BookAppointment(int doctorId, int patientId, DateTime date) // Method to book an appointment`
            {
                Doctor doctor = doctors.FirstOrDefault(d => d.Id == doctorId); 
                Patient patient = patients.FirstOrDefault(p => p.Id == patientId);

                if (doctor == null || patient == null) // Check if doctor or patient exists
                {
                    Console.WriteLine(" Doctor or Patient not found.");
                    return;
                }

                if (appointments.Any(a => a.Doctor.Id == doctorId && a.AppointmentDate == date)) // Check if the doctor is already booked at that time
                {
                    Console.WriteLine(" This doctor is already booked at that time.");
                    return;
                }

                Appointment appointment = new Appointment(appointmentCounter++, doctor, patient, date); // Create a new appointment
                appointments.Add(appointment);
                Console.WriteLine(" Appointment booked successfully.");
            }

            public void ShowAppointments()
            {
                foreach (var appointment in appointments)
                {
                    appointment.Display();
                }
            }

            public void ShowDoctorsBySpecialization(string specialization)
            {
                var filtered = doctors.Where(d => d.Specialization.Equals(specialization, StringComparison.OrdinalIgnoreCase));
                foreach (var doc in filtered)
                {
                    doc.DisplayInfo();
                }
            }

            public void SearchAppointmentsByPatientName(string name)
            {
                var results = appointments.Where(a => a.Patient.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                foreach (var a in results)
                {
                    a.Display();
                }
            }

            public void SearchAppointmentsByDate(DateTime date)
            {
                var results = appointments.Where(a => a.AppointmentDate.Date == date.Date);
                foreach (var a in results)
                {
                    a.Display();
                }
            }
        }
    }
}
