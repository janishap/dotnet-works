
//Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muliples
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if(num%3 ==0 || num %7 == 0)
            {

                Console.WriteLine("The given number is multiple of 3 or 7");
            }


        }
    }
}
