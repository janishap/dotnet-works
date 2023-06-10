//Write a C# Sharp program to copy the elements of one array into another array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayduplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5};
            int[] arr2=new int[arr.Length];
            for(int i=0; i<arr.Length; i++)

            {
                Console.WriteLine(arr[i]);
            }

            for(int i =0; i<arr.Length;i++)
            {
                arr2[i] = arr[i];
            }

            Console.WriteLine("array of  2 is ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
