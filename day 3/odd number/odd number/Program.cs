using System;

namespace odd_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i<= num; i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
