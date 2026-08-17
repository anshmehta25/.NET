using System;
class T2_14
{
    static void Main(string[] args)
    {
        int maths, physics, chemistry;

        Console.Write("Input the marks obtained in Maths: ");
        maths = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the marks obtained in Physics: ");
        physics = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the marks obtained in Chemistry: ");
        chemistry = Convert.ToInt32(Console.ReadLine());

        int total = maths + physics + chemistry;
        int mathPhysics = maths + physics;

        if (maths >= 65 &&
            physics >= 55 &&
            chemistry >= 50 &&
            (total >= 180 || mathPhysics >= 140))
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission.");
        }

        Console.ReadLine();
    }
}
