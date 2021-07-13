using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            Console.Write("Hello All!");
            Console.WriteLine();

            string myText = "Hello!! \n ten tekst będzie w nowej linijce ";
            char smth = 's';
            char cos = ' ';
            string fullText = myText + smth + cos + "WSEI";
            Console.WriteLine(fullText);

            string x = Console.ReadLine();
            char y = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine(x + y);





        }
    }
}
