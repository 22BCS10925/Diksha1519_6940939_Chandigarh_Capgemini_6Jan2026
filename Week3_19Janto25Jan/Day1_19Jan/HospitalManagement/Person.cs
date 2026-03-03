using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement
{
    using System;

    class Person
    {
        public int id;
        public string name;
        public int age;

        public Person() { }

        public void Display()
        {
            Console.WriteLine(id + "  " + name + "  " + age);
        }
    }

    class Patient : Person
    {
        public string disease;

        public Patient(int i, string n, int a, string d)
        {
            id = i;
            name = n;
            age = a;
            disease = d;
        }
    }

    class Doctor : Person
    {
        public string specialization;

        public Doctor(int i, string n, int a, string s)
        {
            id = i;
            name = n;
            age = a;
            specialization = s;
        }
    }

    class Nurse : Person
    {
        public string shift;

        public Nurse(int i, string n, int a, string sh)
        {
            id = i;
            name = n;
            age = a;
            shift = sh;
        }
    }


    class MedicalRecord
    {
        public int recordId;
        public Patient patient;
        public string history;

        public MedicalRecord(int r, Patient p, string h)
        {
            recordId = r;
            patient = p;
            history = h;
        }

        public void ShowRecord()
        {
            Console.WriteLine("\n--- Medical Record ---");
            Console.WriteLine("Record ID: " + recordId);
            Console.WriteLine("Patient: " + patient.name);
            Console.WriteLine("History: " + history);
        }
    }

    class Appointment
    {
        public int appId;
        public Patient patient;
        public Doctor doctor;
        public string date;

        public Appointment(int id, Patient p, Doctor d, string dt)
        {
            appId = id;
            patient = p;
            doctor = d;
            date = dt;
        }

        public void ShowAppointment()
        {
            Console.WriteLine("Appointment Details ");
            Console.WriteLine("Appointment ID: " + appId);
            Console.WriteLine("Patient: " + patient.name);
            Console.WriteLine("Doctor: " + doctor.name);
            Console.WriteLine("Date: " + date);
        }
    }

   
}
