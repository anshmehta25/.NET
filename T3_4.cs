using System;

namespace TutorialIII
{
    class Student
    {
        public int EnrolmentNo { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(int enrolmentNo, string name, int marks)
        {
            EnrolmentNo = enrolmentNo;
            Name = name;
            Marks = marks;
        }

        public void Display()
        {
            Console.WriteLine($"{EnrolmentNo} - {Name} - {Marks}");
        }
    }

    class T3_4
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(101, "Amit", 82);
            Student s2 = new Student(102, "Riya", 76);
            Student s3 = new Student(103, "Karan", 69);
            Student s4 = new Student(104, "Neha", 91);
            Student s5 = new Student(105, "Jay", 58);

            s1.Display();
            s2.Display();
            s3.Display();
            s4.Display();
            s5.Display();
        }
    }
}