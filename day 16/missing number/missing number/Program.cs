using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missing_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 6, 5 };
            int n = 6; //array size should be
            //Console.WriteLine("array elements");

            int sum2 = 0;
            
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int value = 0;
            //for (int j = 0; j < n; j++)
            //{
            //     //value += arr[j] * ((arr[j] + 1) / 2);

            //    //sum1 = sum1 + arr[j];
            //}

            int value= (n)*(n+1)/2;
            for (int k = 0; k < arr.Length; k++)
            {
                //value += arr[j] * ((arr[j] + 1) / 2);

                sum2 = sum2 + arr[k];
            }
            int missing =  value-sum2;



            //int missing = value - sum;

                Console.WriteLine("missing number is "+missing);



            
        }
    }
}   
