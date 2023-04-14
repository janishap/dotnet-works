//swapping two numbers using temp variable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_prgrm_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            Console.WriteLine("before swapping   a is {0} and b is {1}", a, b);
            int temp;

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping a is {0} and b is {1}", a, b);


            //swapping without temp variable

            int x = 20;
            int y = 30;
            Console.WriteLine("before swapping x is {0} and y is {1}", x, y);


            x  = x + y;
             y = x - y;
            x = x - y;
            Console.WriteLine("After swapping  is  x{0}  and y is {1}", x, y);


        }
    }
}
