using System;

namespace Extractisor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Ceiling((decimal) 3.1));
            
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i);
                }
            }

            Console.ReadKey();
        }
    }
}