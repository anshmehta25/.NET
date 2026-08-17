using System;

namespace TutorialIII
{
    class Student
    {
        public int EnrolmentNo { get; set; }
        public string Name { get; set; }

        public Student(int enrolmentNo, string name)
        {
            EnrolmentNo = enrolmentNo;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Enrollment No: " + EnrolmentNo);
            Console.WriteLine("Name: " + Name);
        }
    }

    class T3_7
    {
        static void Main(string[] args)
        {
            Student s = new Student(101, "Rahul");
            s.Display();
        }
    }
}