using System;

namespace Ex_02_01_petle
{
    class Program
    {
        static void Main(string[] args)
        {

          double[] a1 = new double[3];

            a1[0] = 2.0;
            a1[1] = 3.0;
            a1[2] = 5.0;
            Console.WriteLine(a1[0]);

            //To samo co wyżej, tylko krócej ;)
            char[] a2 = { 'W', 'S', 'E', 'I' };


            //3 SPOSÓB INICJALIZACJI TABLICY
            int[] a3 = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < a3.Length; i++)
            {
                a3[i] = rnd.Next(0, 2);
                Console.WriteLine(a3[i]);
            }
          



        }
    }
}
