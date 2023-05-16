using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replace_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());

        //    int temp = n;
        //    int sum = 0;
        //    int rem;
        //    int reverse=0;

        //    while (n > 0)
        //    {

        //         rem = n % 10;
        //        if (rem == 0)
        //        {
        //             rem = 5;
                   
        //        }
        //        sum = sum * 10 + rem;
        //        n = n / 10;
        //    }
        //    while(sum>0)

        //    {
        //        int re = sum % 10;
        //        reverse = reverse * 10 + re;
        //       sum = sum / 10;
        //    }
        //    Console.WriteLine(reverse);

           
        //


         string s=n.ToString();
            string r = s.Replace('0', '5');
            Console.WriteLine(r);   

           
        }
    }
}
