using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_number
{
    internal class Fibonacci_numbers
    {
        public static void Fibonaccinumber()
        {
            int x = 1, y = 2, z, i, n;
            Console.Write("Enter the number of elements: ");
            n = int.Parse(Console.ReadLine());
            Console.Write(x + " " + y + " ");
            for (i = 2; i < n; ++i)
            {
                z = x + y;
                Console.Write(z + " ");
                x = y;
                y = z;
            }
        }
    }
}
