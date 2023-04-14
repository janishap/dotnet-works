//Write a C# program to create a new string from a given string where the first and last characters will change their positions



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_prgrm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            string result = name.Substring(1);
            Console.WriteLine(result);
        }
    }
}
