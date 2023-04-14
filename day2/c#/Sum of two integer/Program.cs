using System;

namespace Sum_of_two_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,sum;
            Console.WriteLine("Enter the first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b= int.Parse(Console.ReadLine());
            sum = calcsum(a, b);
            Console.WriteLine("Sum of two integer {0} and {1} is {2} ", a, b, sum);
        }

        static int calcsum(int a,int b)
        {
            if(a==b)
            {
                int result = (a + b) * 3;
                return result;
            }
            else
            {
                int value = a + b;
                return value;
            }
        }
    }
}
