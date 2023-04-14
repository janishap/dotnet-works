//Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgrm_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        
    }
    }
}
