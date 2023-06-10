// Write a C# Sharp program that stores elements in an array and prints them


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int [10];

            Console.WriteLine("enter the numbers");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());


            }
            Console.WriteLine(arr[6]);
        }
    }
}
