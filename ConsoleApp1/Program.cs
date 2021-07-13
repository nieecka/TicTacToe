using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random(); // random numer generator
            int x = rnd.Next(0, 10);    // random numer od 0 ... 9 (nie wylosuje 10-tki !!)
            int y = rnd.Next(-10, 10);   // random number od -10 ... 9 (BEZ 10-TKI)

            Console.WriteLine("x = {0}, y = {1}", x, y);


            if(x > y)
            {

                Console.WriteLine("x is bigger");

            }
            else if (x == y)
            {
                Console.WriteLine("both are the same");
            }
            else
            {
                Console.WriteLine("y is bigger");
            }





        }
    }
}
