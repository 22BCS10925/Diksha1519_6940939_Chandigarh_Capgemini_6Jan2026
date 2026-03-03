
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientCaseStudy
{
    public class Patient
    {
        string _name;
        int _age;
        string _illness;
        string _city;

        //Default Constructor
        public Patient()
        {

        }

        //Parameterized constructor
        public Patient(string Name, int age, string illness, string city)
        {
            _name = Name;
            _age = age;
            _illness = illness;
            _city = city;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int age
        {
            get { return _age; }
            set { _age = value; }
        }
        public String illness
        {
            get
            {
                return _illness;
            }
            set 
            {
                _illness = value; 
            }
        }
        public String city
        {
            get { return _city; }
            set
            {
                _city = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0,-21}{1,-6}{2,-21}{3,-20}", this._name, this._age, this._illness, this._city);
        }

    }
}
