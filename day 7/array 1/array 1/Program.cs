
//Write a program in C# Sharp to store elements in an array and print it.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arra = new int[5];
            Console.WriteLine("enter the elements");
         for(int i = 0; i< arra.Length; i++) 
            {
                arra[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("ELEMENTS ARE ");

            for(int i =0; i< arra.Length; i++) 
            {

                Console.WriteLine(arra[i]);
            }



        }
    }
}
