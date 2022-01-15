using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_number
{
    internal class Swap_numbers
    {
        public static void Swap numbers()
        { 
            int x = 20, y = 30;
            Console.WriteLine("Before swap:");
            Console.WriteLine("x = " + x + " and y = " + y);
            x = x * y;
            y = x / y;
            x = x / y;
            Console.WriteLine("After swap:");
            Console.WriteLine("x = " + x + " and y = " + y);
        }
    }
}
