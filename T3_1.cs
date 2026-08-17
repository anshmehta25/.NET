using System;

namespace T3_1
{
    // Task 1: Create a class
    class Student
    {
        // Task 2: Private data members
        private int enrolmentNo;
        private string name;
        private int marks;

        // Constructor to initialize student data
        public Student(int enrolmentNo, string name, int marks)
        {
            this.enrolmentNo = enrolmentNo;
            this.name = name;
            this.marks = marks;
        }

        // Task 3: Public method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine("Enrollment No: " + enrolmentNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Marks: " + marks);
        }

        // Public method to check pass/fail
        public void ShowResult()
        {
            if (marks >= 35)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
        }
    }

    // Task 4: Demo class with Main method
    class Demo
    {
        static void Main(string[] args)
        {
            // Task 5: Creating two objects of Student class
            Student s1 = new Student(101, "Ansh", 78);
            Student s2 = new Student(102, "Kartik   ", 45);

            // Calling methods using first object
            Console.WriteLine("Student 1 Details:");
            s1.DisplayDetails();
            s1.ShowResult();

            Console.WriteLine();

            // Calling methods using second object
            Console.WriteLine("Student 2 Details:");
            s2.DisplayDetails();
            s2.ShowResult();

            Console.ReadKey();
        }
    }
}