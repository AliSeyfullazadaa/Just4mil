using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft0001_25_28Nov
{
    internal class Student
    {
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name'i duzgun daxil et");
                    value = Console.ReadLine();
                }
                _name = value;
            }
        }

        string _surName;

        public Student(string? name, string? surname)
        {
            Name = name;
            SurName = surname;
        }

        public string SurName
        {
            get
            {
                return _surName;
            }
            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Surname'i duzgun daxil et");
                    value = Console.ReadLine();
                }
                _surName = value;
            }
        }
    }
}
