//Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.

using System;


namespace decimal_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number");
            decimal d= decimal.Parse(Console.ReadLine());   
        }
    }
}
