using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_sub_array_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the size of array");
            int n= int.Parse(Console.ReadLine());

            int[] arr =new int[n];

            //int sum = 10;
            
            Console.WriteLine("Enter the array elements");
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the sum value");
            int sum = int.Parse(Console.ReadLine());

            for(int j=0;j<arr.Length;j++)
            {
               int s = arr[j];

                for(int k=j+1;k<n;k++)
                {
                    

                    if(sum==s)
                    {
                        Console.WriteLine("{0}  {1}",j+1,k);
                        break;
                    }
                     
                    s = s + arr[k];
                    
                    
                }

                
            }




        }
    }
}
