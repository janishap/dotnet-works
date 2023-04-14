//Write a program in C# Sharp to read n number of values in an array and display it in reverse order



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements in array ");
            int[] arr = new int[5];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arr[]);
            Console.WriteLine("after reversing");
            for (int i = arr.Length; i > 0; i--)
            {
                
            }
        }
    }
}
