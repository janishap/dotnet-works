using System;


namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, sum = 0;
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            int y = num;

            while(num>0)
            {
                x = num % 10;
                sum = (sum * 10) + x;
                num = num / 10;
            }
           if(y == sum)
            {
                Console.WriteLine("Palindrome number");
            }
            else
            {
                Console.WriteLine("not a palindrome number");
            }

           



        }
    }
}
