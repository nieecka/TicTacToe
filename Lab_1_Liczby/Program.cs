using System;

namespace Lab_1_Liczby
{
    class Program
    {
        static void Main(string[] args)
        {

            //Integers
            int a = 1;
            long b = 2;
            long c = a + b;

            //Floating point numbers 
            float f = 2.0f;
            double d = -1.8;

            Console.WriteLine(a);
            Console.WriteLine(2.5 * b);
            Console.WriteLine(f + d);


            //Catsing - rzutowanie

            int dd = (int)d;
            Console.WriteLine("{0} & {1}", dd, d);

            string tmp;

            tmp = Console.ReadLine();
            int.TryParse(tmp, out a);


            tmp = Console.ReadLine();
            double.TryParse(tmp, out d);

            Console.WriteLine(a + " & " + d);

            


        }
    }
}
