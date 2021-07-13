using System;

namespace Nowe_Zadanie_04
{
    class Program
    {
        static void Main(string[] args)
        {

            bool a = true;
            bool b = false;
            bool c = !a;  // false (zaprzeczenie!)

            int x = 10;
            int y = -2;

            bool w = x > y;   //true


            if(w)
            {
                Console.WriteLine("X RULES!");

            }
            else
            {
                Console.WriteLine("Y RULES!");
            }


        }
    }
}
