using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping__k
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 5;
            Console.WriteLine("Before Swapping a is :{0} and b is : {1}", a, b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After swapping a is {0} and b is {1}", a, b);
            
        }
    }
}
