using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mularray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 2, 4, 6, 8 };

            for(int i = 0; i< array1.Length;i++)
            {
                int arr3 = array1[i] * array2[i];
                Console.WriteLine("Multiples of two arrays:\n "+arr3);
            }
        }
    }
}
