using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryctach2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int[] a = new int[5];

            try
            {
                int j = 10 / b;

                 a[10] = 9;
            }
            //catch(Exception e)
            //{
            //    Console.WriteLine("Divide by zero error");
            //}
            catch(Exception e)
            {
                Console.WriteLine("index out of bounds");
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("Remaining program");
        }
    }
}
