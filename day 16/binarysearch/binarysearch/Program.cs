using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearch
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            
            int[] arr = new int[5];

            Console.WriteLine("array elements");

            for(int i=0;  i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("value to be checked in the array");
            int k=int.Parse(Console.ReadLine());

            for(int j=0; j<arr.Length;j++)
            {
                if (arr[j] == k)
                {
                    Console.WriteLine("The index postion of value is  "+ j);
                }
            }
        }
    }
}
