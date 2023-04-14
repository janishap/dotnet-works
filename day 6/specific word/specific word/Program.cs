
//Write a C# program to check if a string starts with a specified word.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specific_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string name = Console.ReadLine();


            Console.WriteLine(name.Length < 6 && name.Equals("Hello") || (name.StartsWith("Hello") && name[5] == ' '));


        }
    }
}
