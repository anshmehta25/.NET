using System;

namespace T3_5
{
    class Product
    {
        int pcode;
        string pname, mname;

        public Product(int pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        public void Display()
        {
            Console.WriteLine("\nProduct Code:= P" + pcode.ToString("D3"));
            Console.WriteLine("\nProduct Name:= " + pname);
            Console.WriteLine("\nManufacturer Name:= " + mname);
        }
    }

    public class T3_5
    {
        public static void Main(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [dotnet run ProductCode ProductName Manufacturer]");
            }
            else
            {
                int pcd = Convert.ToInt32(args[0]);
                string pnm = args[1];
                string mnm = args[2];

                Product p = new Product(pcd, pnm, mnm);
                p.Display();
            }
        }
    }
}