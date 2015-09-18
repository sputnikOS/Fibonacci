using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f1 = 0, f2 = 1;

            Console.Write("Enter the Limit : ");

            var count = int.Parse(Console.ReadLine());

            Console.WriteLine(f1);
            Console.WriteLine(f2);

            for (i = 0; i <= count; i++)
            {
                var f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }

            Console.ReadLine();

        }
    }
}