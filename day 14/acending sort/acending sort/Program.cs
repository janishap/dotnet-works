using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acending_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] arr = new int[n];
            int temp = 0;
            Console.WriteLine("Enter the array");
                for(int i=0;i<arr.Length;i++)
                {
                arr[i]=int.Parse(Console.ReadLine());
                }

               for(int j=0;j<arr.Length;j++)
               {
                  for (int k = j+1; k < arr.Length; k++)

                  {
                    if (arr[k] < arr[j])

                    {
                        temp = arr[k];
                        arr[k] = arr[j];
                        arr[j] = temp;
                        
                    }                
                  }
                
               }

            Console.WriteLine("acending  order is ");
            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.WriteLine(arr[i]);
            }

        }
    }
}