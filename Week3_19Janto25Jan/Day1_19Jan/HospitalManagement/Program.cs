namespace HospitalManagement
{
    class Program
    {
        static void Main()
        {
            Patient p1 = new Patient(1, "Ravi", 30, "Fever");
            Doctor d1 = new Doctor(101, "Dr. Smith", 45, "General");
            Nurse n1 = new Nurse(201, "Anita", 28, "Night");

            Appointment a1 = new Appointment(5001, p1, d1, "12-02-2026");
            MedicalRecord m1 = new MedicalRecord(9001, p1, "High fever for 3 days");

            Console.WriteLine(" HOSPITAL MANAGEMENT SYSTEM ");
            Console.WriteLine("Patient Details:");
            p1.Display();
            Console.WriteLine("Disease: " + p1.disease);

            Console.WriteLine("Doctor Details:");
            d1.Display();
            Console.WriteLine("Specialization: " + d1.specialization);

            Console.WriteLine("\nNurse Details:");
            n1.Display();
            Console.WriteLine("Shift: " + n1.shift);

            a1.ShowAppointment();
            m1.ShowRecord();
        }
    }

}
