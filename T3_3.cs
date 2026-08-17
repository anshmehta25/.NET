using System;

namespace T3_3
{
    class Student
    {
        private int enrolmentNo;
        private string name;
        private int marks;

        public int EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public Student()
        {
            enrolmentNo = 0;
            name = "Unknown";
            marks = 0;
        }

        public Student(int enrolmentNo, string name, int marks)
        {
            this.enrolmentNo = enrolmentNo;
            this.name = name;
            this.marks = marks;
        }

        public void Display()
        {
            Console.WriteLine("Enrollment No: " + enrolmentNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Marks: " + marks);
        }
    }

    class T3_3
    {
        static void Main(string[] args)
        {
            Student s = new Student(101, "Amit", 82);
            s.Display();
        }
    }
}