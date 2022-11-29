using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft0001_25_28Nov
{
    internal class Group
    {
        public string GroupNo { get; set; }
        public  int Limit { get; set; }

        Student[] Students =new Student [0];

        public bool AddStudent(Student student)
        {
            if (Students.Length < Limit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
                return true;
            }
            return false;
        }



        public void GetStudents()
        {
            foreach (Student student in Students)
            {
                Console.Write($"{student.Name}  {student.SurName}");
                Console.WriteLine();
            }
        }

    }
}
